using System.Windows.Forms;

namespace AutoService.Shell.Forms
{
    public class DataGridManager
    {
        private readonly DataGridView dataGrid;

        public DataGridManager(DataGridView dataGrid)
        {
            int n = 4;           
            this.dataGrid = dataGrid;
        }

        public void AddressColumnConfig()
        {
            dataGrid.ColumnCount = 0;

            dataGrid.Columns.Add("0", "ID");
            dataGrid.Columns.Add("1", "Country");
            dataGrid.Columns.Add("2", "City");
            dataGrid.Columns.Add("3", "Street");
            dataGrid.Columns.Add("4", "House");
        }

        public void ClientColumnConfig()
        {
            dataGrid.ColumnCount = 0;

            dataGrid.Columns.Add("0", "ID");
            dataGrid.Columns.Add("1", "Name");
            dataGrid.Columns.Add("2", "Surname");
            dataGrid.Columns.Add("3", "Patronymic");
            dataGrid.Columns.Add("4", "Email");
            dataGrid.Columns.Add("5", "Address ID");
        }

        public void DriverLicenseColumnConfig()
        {
            dataGrid.ColumnCount = 0;

            dataGrid.Columns.Add("0", "ID");
            dataGrid.Columns.Add("1", "Number");
            dataGrid.Columns.Add("2", "Year");
            dataGrid.Columns.Add("3", "Month");
            dataGrid.Columns.Add("4", "Day");
            dataGrid.Columns.Add("5", "Vehicle category");
            dataGrid.Columns.Add("6", "Client ID");
        }

        public void TransportColumnConfig()
        {
            dataGrid.ColumnCount = 0;

            dataGrid.Columns.Add("0", "ID");
            dataGrid.Columns.Add("1", "Number");
            dataGrid.Columns.Add("2", "Make ID");
            dataGrid.Columns.Add("3", "Model ID");
            dataGrid.Columns.Add("4", "Fuel ID");
            dataGrid.Columns.Add("5", "Category ID");
            dataGrid.Columns.Add("6", "Client ID");
        }

        public void TransportModelColumnConfig()
        {
            dataGrid.ColumnCount = 0;

            dataGrid.Columns.Add("0", "ID");
            dataGrid.Columns.Add("1", "Name");
        }

        public void TransportMakeColumnConfig()
        {
            dataGrid.ColumnCount = 0;

            dataGrid.Columns.Add("0", "ID");
            dataGrid.Columns.Add("1", "Name");
        }

        public void TransportCategoryColumnConfig()
        {
            dataGrid.ColumnCount = 0;

            dataGrid.Columns.Add("0", "ID");
            dataGrid.Columns.Add("1", "Name");
        }

        public void InspectionColumnConfig()
        {
            dataGrid.ColumnCount = 0;

            dataGrid.Columns.Add("0", "ID");
            dataGrid.Columns.Add("1", "Number");
            dataGrid.Columns.Add("2", "Start year");
            dataGrid.Columns.Add("3", "Expire year");
            dataGrid.Columns.Add("4", "Is passed");
            dataGrid.Columns.Add("5", "Vehicle ID");
        }

        public void FuelColumnConfig()
        {
            dataGrid.ColumnCount = 0;

            dataGrid.Columns.Add("0", "ID");
            dataGrid.Columns.Add("1", "Name");
        }

        public void ColumnWidthConfig(int width)
        {
            foreach (DataGridViewColumn column in dataGrid.Columns)
            {
                column.Width = width;
            }
        }

        public bool SearchRow(string word)
        {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString() == word)
                    {
                        dataGrid.ClearSelection();
                        row.Selected = true;
                        return true;
                    }
                }
            }

            return false;
        }
    }
}