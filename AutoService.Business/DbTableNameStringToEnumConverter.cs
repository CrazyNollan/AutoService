using AutoService.Business.Enums;
using System;

namespace AutoService.Business
{
    public static class TableNameToEnumConverter
    {
        public static DbTable Convert(string tableName)
        {
            switch (tableName)
            {
                case "Addresses":
                    return DbTable.Addresses;
                case "Clients":
                    return DbTable.Clients;
                case "Driver Licences":
                    return DbTable.DriverLicences;
                case "Vehicles":
                    return DbTable.Transport;
                case "Vehicle makes":
                    return DbTable.TransportMakes;
                case "Vehicle models":
                    return DbTable.TransportModels;
                case "Vehicle categories":
                    return DbTable.TransportCategories;
                case "Fuel":
                    return DbTable.Fuel;
                case "Inspections":
                    return DbTable.Inspections;
                default:
                    throw new ArgumentException("Incorrect value of tableName argument", "tableName");
            }
        }
    }
}