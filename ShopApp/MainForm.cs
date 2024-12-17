using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ShopApp.Form1;
using ShopLib;
using deskbooks;
using System.Data.SQLite;
using System.Reflection;

namespace ShopApp
{
    public partial class MainForm : Form
    {

        private readonly int _userId;


        public MainForm(int userId)
        {

            _userId = userId;
            InitializeComponent();
            var menuItems = MenuService.GetMenuItemsByUserId(_userId);
            BuildMenu(menuItems);
            TabControl mainTabControl = new TabControl();
            mainTabControl.Dock = DockStyle.Fill; // Растягиваем по всей форме
            this.Controls.Add(mainTabControl);
        }

        private void BuildMenu(IEnumerable<MenuItemModel> menuItems)
        {
            var mainMenu = new MenuStrip();

            // Создаем меню на основе списка
            var menuLookup = menuItems.ToLookup(m => m.ParentMenuId);

            // Рекурсивно добавляем пункты
            foreach (var rootItem in menuLookup[0])
            {
                var rootMenu = new ToolStripMenuItem(rootItem.Name);
                rootMenu.Tag = rootItem;
                if (rootItem.FunctionName != null & rootItem.DllName != null)
                {
                    rootMenu.Click += (s, e) => ExecuteMenuItem((MenuItemModel)((ToolStripMenuItem)s).Tag);
                }
                AddSubMenu(rootMenu, rootItem.MenuId, menuLookup);
                mainMenu.Items.Add(rootMenu);
            }

            // Добавляем меню на форму
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
        }

        private void AddSubMenu(ToolStripMenuItem parentMenu, int parentId, ILookup<int, MenuItemModel> menuLookup)
        {
            foreach (var item in menuLookup[parentId])
            {
                var subMenu = new ToolStripMenuItem(item.Name);
                subMenu.Tag = item;

                // Если это не пункт с дочерними элементами
                if (!string.IsNullOrEmpty(item.FunctionName))
                {
                    subMenu.Click += (s, e) => ExecuteMenuItem((MenuItemModel)((ToolStripMenuItem)s).Tag);
                }

                parentMenu.DropDownItems.Add(subMenu);

                // Рекурсивно добавляем подпункты
                AddSubMenu(subMenu, item.MenuId, menuLookup);
            }
        }

        private void ExecuteMenuItem(MenuItemModel menuItem)
        {

            if (string.IsNullOrEmpty(menuItem.DllName) || string.IsNullOrEmpty(menuItem.FunctionName))
            {
                MessageBox.Show("Этот пункт меню не связан с функцией.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Загружаем DLL
                var assembly = Assembly.LoadFrom(menuItem.DllName);

                // Ищем тип с нужной функцией
                var type = assembly.GetTypes().FirstOrDefault(t => t.GetMethod(menuItem.FunctionName) != null);

                if (type == null)
                {
                    throw new Exception($"Функция '{menuItem.FunctionName}' не найдена в DLL '{menuItem.DllName}'.");
                }

                // Создаем экземпляр типа
                var instance = Activator.CreateInstance(type);
                object[] arguments = new object[] { _userId, mainTabControl };
                // Вызываем метод
                var method = type.GetMethod(menuItem.FunctionName);
                method.Invoke(instance, arguments);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при вызове функции из DLL: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
   


