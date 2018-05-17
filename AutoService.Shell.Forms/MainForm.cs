using AutoService.Business;
using AutoService.Business.Enums;
using AutoService.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService.Shell.Forms
{
    public partial class MainForm : Form
    {
        #region LOCALS

        private readonly IAddressManager addressManager;
        private readonly IClientManager clientManager;
        private readonly IDriverLicenseManager driverLicenseManager;
        private readonly IFuelManager fuelManager;
        private readonly IInspectionManager inspectionManager;
        private readonly ITransportCategoryManager transportCategoryManager;
        private readonly ITransportMakeManager transportMakeManager;
        private readonly ITransportManager transportManager;
        private readonly ITransportModelManager transportModelManager;
        private readonly AboutForm aboutForm;
        private readonly DataGridManager dataGridManager;

        #endregion

        public MainForm(IAddressManager addressManager, IClientManager clientManager, IDriverLicenseManager driverLicenseManager, IFuelManager fuelManager,
                        IInspectionManager inspectionManager, ITransportCategoryManager transportCategoryManager, ITransportMakeManager transportMakeManager,
                        ITransportManager transportManager, ITransportModelManager transportModelManager, AboutForm aboutForm)
        {
            InitializeComponent();
            this.addressManager = addressManager;
            this.clientManager = clientManager;
            this.driverLicenseManager = driverLicenseManager;
            this.fuelManager = fuelManager;
            this.inspectionManager = inspectionManager;
            this.transportCategoryManager = transportCategoryManager;
            this.transportMakeManager = transportMakeManager;
            this.transportManager = transportManager;
            this.transportModelManager = transportModelManager;
            this.aboutForm = aboutForm;
            dataGridManager = new DataGridManager(dataGrid);
        }

        // При выборе таблицы в выпадающем списке
        private async void tableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbTable tableName = TableNameToEnumConverter.Convert(tableComboBox.AccessibilityObject.Value?.ToString());

            await DataGridDataInitialize(tableName);
        }

        // Кнопка Add
        private void addButton_Click(object sender, EventArgs e)
        {
            DbTable tableName = TableNameToEnumConverter.Convert(tableComboBox.AccessibilityObject.Value?.ToString());

            switch (tableName)
            {
                case DbTable.Addresses:
                    addressPanel.Visible = true;
                    break;
                case DbTable.Clients:
                    clientPanel.Visible = true;
                    break;
                case DbTable.DriverLicences:
                    driverLicensePanel.Visible = true;
                    break;
                case DbTable.Transport:
                    transportPanel.Visible = true;
                    break;
                case DbTable.TransportMakes:
                    transportMakePanel.Visible = true;
                    break;
                case DbTable.TransportModels:
                    transportModelPanel.Visible = true;
                    break;
                case DbTable.TransportCategories:
                    transportCategoryPanel.Visible = true;
                    break;
                case DbTable.Fuel:
                    fuelPanel.Visible = true;
                    break;
                case DbTable.Inspections:
                    inspectionPanel.Visible = true;
                    break;
                default:
                    throw new ArgumentException("Incorrect value of tableName argument", "tableName");
            }
        }

        // Кнопка Edit
        private void editButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #region SEARCH RECORD

        // Кнопка Search
        private void searchButton_Click(object sender, EventArgs e)
        {
            searchPanel.Visible = true;
        }

        // Кнопка подтверждения поиска
        private void searchConfirmButton_Click(object sender, EventArgs e)
        {
            bool searchResult = false;
            string word = searchWordTextBox.Text;
            string resultMessage = "Something went wrong, try again";

            if (string.IsNullOrEmpty(word))
            {
                resultMessage = "Required fields are not filled, try again";
            }
            else
            {
                searchResult = dataGridManager.SearchRow(word);

                if (searchResult)
                {
                    resultMessage = "Record was successfully found";
                }
                else
                {
                    resultMessage = "Record was not found, try again";
                }
            }

            MessageBox.Show(resultMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (searchResult)
            {
                searchPanel.Visible = false;
                searchWordTextBox.Text = "";
            }
        }

        // Кнопка отмены поиска
        private void searchCancelButton_Click(object sender, EventArgs e)
        {
            searchPanel.Visible = false;
            searchWordTextBox.Text = "";
        }

        #endregion

        #region DELETE RECORD

        // Кнопка открытия панели удаления
        private void deleteButton_Click(object sender, EventArgs e)
        {
            deletePanel.Visible = true;
        }

        // Кнопка подтверждения удаления
        private async void confirmDeleteButton_Click(object sender, EventArgs e)
        {
            DeleteResult deleteResult = DeleteResult.Failed;
            DbTable tableName = TableNameToEnumConverter.Convert(tableComboBox.AccessibilityObject.Value?.ToString());
            IDbTableManager dbTableManager = GetTableManager(tableName);
            string recordId = deleteRecordIdTextBox.Text;
            string resultMessage = "Something went wrong, try again";

            if (string.IsNullOrEmpty(recordId))
            {
                resultMessage = "Record ID field is required, try again";
            }
            else
            {
                deleteResult = await dbTableManager.DeleteRecord(int.Parse(recordId));

                if (deleteResult == DeleteResult.RecordNotFound)
                {
                    resultMessage = "Record not found, try again";
                }
                else if (deleteResult == DeleteResult.Success)
                {
                    resultMessage = "Record was successfully deleted";
                }
            }

            MessageBox.Show(resultMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (deleteResult == DeleteResult.Success)
            {
                deletePanel.Visible = false;
                deleteRecordIdTextBox.Text = "";
                await DataGridDataInitialize(tableName);
            }
        }

        // Кнопка отмены удаления
        private void deleteCancelButton_Click(object sender, EventArgs e)
        {
            deletePanel.Visible = false;
            deleteRecordIdTextBox.Text = "";
        }

        #endregion

        #region ADDRESS

        // Кнопка добавления записи в Addresses
        private async void addressConfirmButton_Click(object sender, EventArgs e)
        {
            AddResult addResult = AddResult.Failed;
            string country = addressCountryTextbox.Text;
            string city = addressCityTextbox.Text;
            string street = addressStreetTextbox.Text;
            string house = addressHouseTextbox.Text;
            string resultMessage = "Something went wrong, try again";

            if (string.IsNullOrEmpty(country) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(street) || string.IsNullOrEmpty(house))
            {
                resultMessage = "Required fields are not filled, try again";
            }
            else
            {
                addResult = await addressManager.AddRecord(country, city, street, int.Parse(house));

                if (addResult == AddResult.Success)
                {
                    resultMessage = "Record was successfully added";
                }
            }

            MessageBox.Show(resultMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (addResult == AddResult.Success)
            {
                OnAddressPanelLeave();
                await DataGridDataInitialize(DbTable.Addresses);
            }
        }

        // Кнопка отмены добавления в Addresses
        private void addressCancelButton_Click(object sender, EventArgs e)
        {
            OnAddressPanelLeave();
        }

        // При закрытии панели добавления в Addresses
        private void OnAddressPanelLeave()
        {
            addressPanel.Visible = false;
            addressCountryTextbox.Text = "";
            addressCityTextbox.Text = "";
            addressStreetTextbox.Text = "";
            addressHouseTextbox.Text = "";
        }

        #endregion

        #region CLIENT

        // Кнопка добавления записи в Clients
        private async void clientConfirmButton_Click(object sender, EventArgs e)
        {
            AddResult addResult = AddResult.Failed;
            string name = clientNameTextBox.Text;
            string surname = clientSurnameTextBox.Text;
            string patronymic = clientPatronymicTextBox.Text;
            string email = clientEmailTextBox.Text;
            string addressId = clientAddressIDTextBox.Text;
            string resultMessage = "Something went wrong, try again";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(patronymic) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(addressId))
            {
                resultMessage = "Required fields are not filled, try again";
            }
            else
            {
                addResult = await clientManager.AddRecord(name, surname, patronymic, email, int.Parse(addressId));

                if (addResult == AddResult.Success)
                {
                    resultMessage = "Record was successfully added";
                }
            }

            MessageBox.Show(resultMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (addResult == AddResult.Success)
            {
                OnClientPanelLeave();
                await DataGridDataInitialize(DbTable.Clients);
            }
        }

        // Кнопка отмены добавления в Clients
        private void clientCancelButton_Click(object sender, EventArgs e)
        {
            OnClientPanelLeave();
        }

        // При закрытии панели добавления в Clients
        private void OnClientPanelLeave()
        {
            clientPanel.Visible = false;
            clientNameTextBox.Text = "";
            clientSurnameTextBox.Text = "";
            clientPatronymicTextBox.Text = "";
            clientEmailTextBox.Text = "";
            clientAddressIDTextBox.Text = "";
        }

        #endregion

        #region DRIVER LICENSE

        // Кнопка добавления записи в Driver Licenses
        private async void driverLicenseConfirmButton_Click(object sender, EventArgs e)
        {
            AddResult addResult = AddResult.Failed;
            string number = driverLicenseNumberTextBox.Text;
            string year = driverLicenseYearTextBox.Text;
            string month = driverLicenseMonthTextBox.Text;
            string day = driverLicenseDayTextBox.Text;
            string transportCategoryId = driverLicenseTransportCategoryTextBox.Text;
            string clientId = driverLicenseClientIDTextBox.Text;
            string resultMessage = "Something went wrong, try again";

            if (string.IsNullOrEmpty(number) || string.IsNullOrEmpty(year) || string.IsNullOrEmpty(month) || string.IsNullOrEmpty(day) || string.IsNullOrEmpty(transportCategoryId) ||
                string.IsNullOrEmpty(clientId))
            {
                resultMessage = "Required fields are not filled, try again";
            }
            else
            {
                addResult = await driverLicenseManager.AddRecord(number, int.Parse(year), int.Parse(month), int.Parse(day), int.Parse(transportCategoryId), int.Parse(clientId));

                if (addResult == AddResult.Success)
                {
                    resultMessage = "Record was successfully added";
                }
            }

            MessageBox.Show(resultMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (addResult == AddResult.Success)
            {
                OnDriverLicensePanelLeave();
                await DataGridDataInitialize(DbTable.DriverLicences);
            }
        }

        // Кнопка отмены добавления в Driver Licenses
        private void driverLicenseCancelButton_Click(object sender, EventArgs e)
        {
            OnDriverLicensePanelLeave();
        }

        // При закрытии панели добавления в Driver Licenses
        private void OnDriverLicensePanelLeave()
        {
            driverLicensePanel.Visible = false;
            driverLicenseNumberTextBox.Text = "";
            driverLicenseYearTextBox.Text = "";
            driverLicenseMonthTextBox.Text = "";
            driverLicenseDayTextBox.Text = "";
            driverLicenseTransportCategoryTextBox.Text = "";
            driverLicenseClientIDTextBox.Text = "";
        }

        #endregion

        #region FUEL

        // Кнопка добавления записи в Fuel
        private async void fuelConfirmButton_Click(object sender, EventArgs e)
        {
            AddResult addResult = AddResult.Failed;
            string name = fuelNameTextBox.Text;
            string resultMessage = "Something went wrong, try again";

            if (string.IsNullOrEmpty(name))
            {
                resultMessage = "Required fields are not filled, try again";
            }
            else
            {
                addResult = await fuelManager.AddRecord(name);

                if (addResult == AddResult.Success)
                {
                    resultMessage = "Record was successfully added";
                }
            }

            MessageBox.Show(resultMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (addResult == AddResult.Success)
            {
                OnFuelPanelLeave();
                await DataGridDataInitialize(DbTable.Fuel);
            }
        }

        // Кнопка отмены добавления в Fuel
        private void fuelCancelButton_Click(object sender, EventArgs e)
        {
            OnFuelPanelLeave();
        }

        // При закрытии панели добавления в Fuel
        private void OnFuelPanelLeave()
        {
            fuelPanel.Visible = false;
            fuelNameTextBox.Text = "";
        }

        #endregion

        #region INSPECTION

        // Кнопка добавления записи в Inspections
        private async void inspectionConfirmButton_Click(object sender, EventArgs e)
        {
            AddResult addResult = AddResult.Failed;
            string number = inspectionNumberTextBox.Text;
            string startYear = inspectionStartYearTextBox.Text;
            string expireYear = inspectionExpireYearTextBox.Text;
            string isPassed = inspectionIsPassedTextBox.Text;
            string transportId = inspectionTransportIDTextBox.Text;
            string resultMessage = "Something went wrong, try again";

            if (string.IsNullOrEmpty(number) || string.IsNullOrEmpty(startYear) || string.IsNullOrEmpty(expireYear) || string.IsNullOrEmpty(isPassed) ||
                string.IsNullOrEmpty(transportId))
            {
                resultMessage = "Required fields are not filled, try again";
            }
            else
            {
                addResult = await inspectionManager.AddRecord(number, int.Parse(startYear), int.Parse(expireYear), bool.Parse(isPassed), int.Parse(transportId));

                if (addResult == AddResult.Success)
                {
                    resultMessage = "Record was successfully added";
                }
            }

            MessageBox.Show(resultMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (addResult == AddResult.Success)
            {
                OnInspectionPanelLeave();
                await DataGridDataInitialize(DbTable.Inspections);
            }
        }

        // Кнопка отмены добавления в Inspections
        private void inspectionCancelButton_Click(object sender, EventArgs e)
        {
            OnInspectionPanelLeave();
        }

        // При закрытии панели добавления в Inspections
        private void OnInspectionPanelLeave()
        {
            inspectionPanel.Visible = false;
            inspectionNumberTextBox.Text = "";
            inspectionStartYearTextBox.Text = "";
            inspectionExpireYearTextBox.Text = "";
            inspectionIsPassedTextBox.Text = "";
            inspectionTransportIDTextBox.Text = "";
        }

        #endregion

        #region TRANSPORT CATEGORY

        // Кнопка добавления записи в Transport categories
        private async void transportCategoryConfirmButton_Click(object sender, EventArgs e)
        {
            AddResult addResult = AddResult.Failed;
            string name = transportCategoryNameTextBox.Text;
            string resultMessage = "Something went wrong, try again";

            if (string.IsNullOrEmpty(name))
            {
                resultMessage = "Required fields are not filled, try again";
            }
            else
            {
                addResult = await transportCategoryManager.AddRecord(name);

                if (addResult == AddResult.Success)
                {
                    resultMessage = "Record was successfully added";
                }
            }

            MessageBox.Show(resultMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (addResult == AddResult.Success)
            {
                OnTransportCategoryPanelLeave();
                await DataGridDataInitialize(DbTable.TransportCategories);
            }
        }

        // Кнопка отмены добавления в Transport categories
        private void transportCategoryCancelButton_Click(object sender, EventArgs e)
        {
            OnTransportCategoryPanelLeave();
        }

        // При закрытии панели добавления в Transport categories
        private void OnTransportCategoryPanelLeave()
        {
            transportCategoryPanel.Visible = false;
            transportCategoryNameTextBox.Text = "";
        }

        #endregion

        #region TRANSPORT MODEL

        // Кнопка добавления записи в Transport models
        private async void transportModelConfirmButton_Click(object sender, EventArgs e)
        {
            AddResult addResult = AddResult.Failed;
            string name = transportModelNameTextBox.Text;
            string resultMessage = "Something went wrong, try again";

            if (string.IsNullOrEmpty(name))
            {
                resultMessage = "Required fields are not filled, try again";
            }
            else
            {
                addResult = await transportModelManager.AddRecord(name);

                if (addResult == AddResult.Success)
                {
                    resultMessage = "Record was successfully added";
                }
            }

            MessageBox.Show(resultMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (addResult == AddResult.Success)
            {
                OnTransportModelPanelLeave();
                await DataGridDataInitialize(DbTable.TransportModels);
            }
        }

        // Кнопка отмены добавления в Transport models
        private void transportModelCancelButton_Click(object sender, EventArgs e)
        {
            OnTransportModelPanelLeave();
        }

        // При закрытии панели добавления в Transport models
        private void OnTransportModelPanelLeave()
        {
            transportModelPanel.Visible = false;
            transportModelNameTextBox.Text = "";
        }

        #endregion

        #region TRANSPORT MAKE

        // Кнопка добавления записи в Transport makes
        private async void transportMakeConfirmButton_Click(object sender, EventArgs e)
        {
            AddResult addResult = AddResult.Failed;
            string name = transportMakeNameTextBox.Text;
            string resultMessage = "Something went wrong, try again";

            if (string.IsNullOrEmpty(name))
            {
                resultMessage = "Required fields are not filled, try again";
            }
            else
            {
                addResult = await transportMakeManager.AddRecord(name);

                if (addResult == AddResult.Success)
                {
                    resultMessage = "Record was successfully added";
                }
            }

            MessageBox.Show(resultMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (addResult == AddResult.Success)
            {
                OnTransportMakePanelLeave();
                await DataGridDataInitialize(DbTable.TransportMakes);
            }
        }

        // Кнопка отмены добавления в Transport makes
        private void transportMakeCancelButton_Click(object sender, EventArgs e)
        {
            OnTransportMakePanelLeave();
        }

        // При закрытии панели добавления в Transport makes
        private void OnTransportMakePanelLeave()
        {
            transportMakePanel.Visible = false;
            transportMakeNameTextBox.Text = "";
        }

        #endregion

        #region TRANSPORT

        // Кнопка добавления записи в Transport
        private async void transportConfirmButton_Click(object sender, EventArgs e)
        {
            AddResult addResult = AddResult.Failed;
            string number = transportNumberTextBox.Text;
            string makeId = transportMakeIDTextBox.Text;
            string modelId = transportModelIDTextBox.Text;
            string categoryId = transportCategoryIDTextBox.Text;
            string fuelId = transportFuelIDTextBox.Text;
            string clientId = transportClientIDTextBox.Text;
            string resultMessage = "Something went wrong, try again";

            if (string.IsNullOrEmpty(number) || string.IsNullOrEmpty(makeId) || string.IsNullOrEmpty(modelId) || string.IsNullOrEmpty(categoryId) || string.IsNullOrEmpty(fuelId) ||
                string.IsNullOrEmpty(clientId))
            {
                resultMessage = "Required fields are not filled, try again";
            }
            else
            {
                addResult = await transportManager.AddRecord(number, int.Parse(makeId), int.Parse(modelId), int.Parse(fuelId), int.Parse(categoryId), int.Parse(clientId));

                if (addResult == AddResult.Success)
                {
                    resultMessage = "Record was successfully added";
                }
            }

            MessageBox.Show(resultMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (addResult == AddResult.Success)
            {
                OnTransportPanelLeave();
                await DataGridDataInitialize(DbTable.Transport);
            }
        }

        // Кнопка отмены добавления в Transport
        private void transportCancelButton_Click(object sender, EventArgs e)
        {
            OnTransportPanelLeave();
        }

        // При закрытии панели добавления в Transport 
        private void OnTransportPanelLeave()
        {
            transportPanel.Visible = false;
            transportNumberTextBox.Text = "";
            transportMakeIDTextBox.Text = "";
            transportModelIDTextBox.Text = "";
            transportCategoryIDTextBox.Text = "";
            transportFuelIDTextBox.Text = "";
            transportClientIDTextBox.Text = "";
        }

        #endregion

        // Кнопка открытия формы About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm.Show();
            this.Hide();
        }

        // При закрытии формы через кнопку
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenForms["LoginForm"]?.Show();
            this.Hide();
        }

        // При закрытии формы принудительно
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Application.OpenForms["LoginForm"]?.Show();
            this.Hide();
        }

        // Отображение данных таблицы БД в dataGrid
        private async Task DataGridDataInitialize(DbTable tableName)
        {
            IEnumerable<string[]> data;

            switch (tableName)
            {
                case DbTable.Addresses:
                    data = await addressManager.GetDataAsync();
                    dataGridManager.AddressColumnConfig();
                    break;
                case DbTable.Clients:
                    data = await clientManager.GetDataAsync();
                    dataGridManager.ClientColumnConfig();
                    break;
                case DbTable.DriverLicences:
                    data = await driverLicenseManager.GetDataAsync();
                    dataGridManager.DriverLicenseColumnConfig();
                    break;
                case DbTable.Transport:
                    data = await transportManager.GetDataAsync();
                    dataGridManager.TransportColumnConfig();
                    break;
                case DbTable.TransportMakes:
                    data = await transportMakeManager.GetDataAsync();
                    dataGridManager.TransportMakeColumnConfig();
                    break;
                case DbTable.TransportModels:
                    data = await transportModelManager.GetDataAsync();
                    dataGridManager.TransportModelColumnConfig();
                    break;
                case DbTable.TransportCategories:
                    data = await transportCategoryManager.GetDataAsync();
                    dataGridManager.TransportCategoryColumnConfig();
                    break;
                case DbTable.Fuel:
                    data = await fuelManager.GetDataAsync();
                    dataGridManager.FuelColumnConfig();
                    break;
                case DbTable.Inspections:
                    data = await inspectionManager.GetDataAsync();
                    dataGridManager.InspectionColumnConfig();
                    break;
                default:
                    throw new ArgumentException("Incorrect value of tableName argument", "tableName");
            }

            foreach (string[] record in data)
            {
                dataGrid.Rows.Add(record);
            }

            dataGridManager.ColumnWidthConfig(130);
        }

        // Получение нужного менеджера в зависимости от имени таблицы
        private IDbTableManager GetTableManager(DbTable tableName)
        {
            switch (tableName)
            {
                case DbTable.Addresses:
                    return addressManager;
                case DbTable.Clients:
                    return clientManager;
                case DbTable.DriverLicences:
                    return driverLicenseManager;
                case DbTable.Transport:
                    return transportManager;
                case DbTable.TransportMakes:
                    return transportMakeManager;
                case DbTable.TransportModels:
                    return transportModelManager;
                case DbTable.TransportCategories:
                    return transportCategoryManager;
                case DbTable.Fuel:
                    return fuelManager;
                case DbTable.Inspections:
                    return inspectionManager;
                default:
                    throw new ArgumentException("Incorrect value of tableName argument", "tableName");
            }
        }
    }
}