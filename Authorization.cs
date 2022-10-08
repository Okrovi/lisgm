namespace LISGM
{
    internal class Authorization
    {
        private string login;
        private string password;
        AuthorizationsWindow screenAuthorizations = new AuthorizationsWindow();

        public Authorization(string login, string password, AuthorizationsWindow screenAuthorizations)
        {
            this.login = login;
            this.password = password;
            this.screenAuthorizations = screenAuthorizations;
        }

        public string loginUser()
        {
            DatabaseInteraction databaseInteraction = new DatabaseInteraction();
            DataDB dataDB = new DataDB();

            dataDB = databaseInteraction.RequestAutorization(this.login, this.password);

            if (dataDB.receivedData != null)
            {
                int columnLogin = 0;
                int columnPassword = 0;
                int columnId = 0;
                int columnIdEmpPoss = 0;
                int columnSurname = 0;
                int columnFirstname = 0;
                int columnPatronymic = 0;
                int columnNumberPhone = 0;
                int columnEmail = 0;

                for (int i = 0; i < dataDB.columnCount; i++)
                {
                    if (dataDB.columnName[i] == databaseInteraction.idUser.Substring(1, databaseInteraction.idUser.Length - 2))
                    {
                        columnId = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.idEmployeesPositionFK.Substring(1, databaseInteraction.idEmployeesPositionFK.Length - 2))
                    {
                        columnIdEmpPoss = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.surnameUser.Substring(1, databaseInteraction.surnameUser.Length - 2))
                    {
                        columnSurname = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.firstnameUser.Substring(1, databaseInteraction.firstnameUser.Length - 2))
                    {
                        columnFirstname = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.patronymicUser.Substring(1, databaseInteraction.patronymicUser.Length - 2))
                    {
                        columnPatronymic = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.phonenumberUser.Substring(1, databaseInteraction.phonenumberUser.Length - 2))
                    {
                        columnNumberPhone = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.emailUser.Substring(1, databaseInteraction.emailUser.Length - 2))
                    {
                        columnEmail = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.loginUser.Substring(1, databaseInteraction.loginUser.Length - 2))
                    {
                        columnLogin = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.passwordUser.Substring(1, databaseInteraction.passwordUser.Length - 2))
                    {
                        columnPassword = i;
                    }
                }

                if (this.login == dataDB.receivedData[columnLogin] & this.password == dataDB.receivedData[columnPassword])
                {
                    screenAuthorizations.userApp.id = dataDB.receivedData[columnId];
                    screenAuthorizations.userApp.employeesPosition = dataDB.receivedData[columnIdEmpPoss];
                    screenAuthorizations.userApp.surname = dataDB.receivedData[columnSurname];
                    screenAuthorizations.userApp.firstname = dataDB.receivedData[columnFirstname];
                    screenAuthorizations.userApp.patronymic = dataDB.receivedData[columnPatronymic];
                    screenAuthorizations.userApp.phone_number = dataDB.receivedData[columnNumberPhone];
                    screenAuthorizations.userApp.email = dataDB.receivedData[columnEmail];
                    return "NEr";
                }
                else return "Er";
            }
            else return "ErDB";
        }
    }    
}
