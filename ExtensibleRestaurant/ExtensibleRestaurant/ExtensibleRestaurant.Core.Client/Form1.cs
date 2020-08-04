using ExtensibleRestaurant.Api;
using ExtensibleRestaurant.Core.Server;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ExtensibleRestaurant.Core.Client
{
    public partial class Form1 : Form
    {
        private readonly ExtensibleRestaurantServer _extensibleRestaurant;

        public Form1()
        {
            InitializeComponent();

            _extensibleRestaurant = new ExtensibleRestaurantServer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddMenuItems();
            AddCustomActionButtons();
        }

        private void AddCustomActionButtons()
        {
            var customActions = _extensibleRestaurant.GetCustomActions();

            foreach (var customAction in customActions)
                CreateButtonAndAddToPanel(customAction);
        }

        private void CreateButtonAndAddToPanel(ICustomAction customAction)
        {
            var button = new Button
            {
                Text = customAction.Name,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                AutoSize = true
            };

            button.Click += new EventHandler(customAction.Execute);

            panelCustomActions.Controls.Add(button);
        }

        private void AddMenuItems()
        {
            var items = _extensibleRestaurant.GetMenuItems();

            comboBoxMenuItems.Items.AddRange(items.ToArray());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var menuItem = (MenuItem)comboBoxMenuItems.SelectedItem;

            _extensibleRestaurant.NotifyItemAddedObservers(menuItem);

            textBoxOrder.AppendText(menuItem.ToString());
            textBoxOrder.AppendText(Environment.NewLine);
        }
    }
}