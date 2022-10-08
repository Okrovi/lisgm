using System.Xml;

namespace LISGM
{
    internal class ConfigurationData
    {
        public ConfigurationData()
        {
        }

        public string ValueFromConf(string namenode)
        {
            string value = "";

            XmlDocument config = new XmlDocument();
            config.Load("config.xml");

            XmlElement? rootconfig = config.DocumentElement;

            if(rootconfig != null)
            {
                foreach(XmlNode unknownode in rootconfig)
                {
                    if(unknownode.NodeType.ToString() == "Element")
                    {
                        XmlElement confignode = (XmlElement)unknownode;

                        if (confignode.Name == namenode)
                        {
                            value = confignode.InnerText;
                        }
                    }                    
                }
            }
            else
            {
                value = "ERRORINCONFIGFILE";
            }

            return value;
        }

        public int loadConf()
        {
            XmlDocument config = new XmlDocument();

            try
            {
                config.Load("config.xml");
                return 0;
            }
            catch(System.IO.FileNotFoundException)
            {
                config.LoadXml("<Root>" +
                    "  <!--Database connection data-->" +
                    "  <IPDB>127.0.0.1</IPDB>" +
                    "  <PORTDB>5432</PORTDB>" +
                    "  <LOGINTOCONNECT>postgres</LOGINTOCONNECT>" +
                    "  <PASSTOCONNECT>postgres</PASSTOCONNECT>" +
                    "  <NAMEDB>logisticappdb</NAMEDB>" +
                    "  <!--Employes position-->" +
                    "  <EMPPOSMANAGER>Manager</EMPPOSMANAGER>" +
                    "  <EMPPOSLOGISTICIAN>Logistician</EMPPOSLOGISTICIAN>" +
                    "  <EMPPOSADMIN>Admin</EMPPOSADMIN>" +
                    "  <!--Supplier position name-->" +
                    "  <POSNAMESUPPLIER>Поставщик</POSNAMESUPPLIER>" +
                    "  <!--Realated values of table names-->" +
                    "  <USERAPPTABLE>USERAPP</USERAPPTABLE>" +
                    "  <EMPPOSTABLE>EMPPOS</EMPPOSTABLE>" +
                    "  <CATEGORYPRODTABLE>CATEGORYPROD</CATEGORYPRODTABLE>" +
                    "  <PRODUCTTABLE>NOMENCLATURE</PRODUCTTABLE>" +
                    "  <PRICEPRODTABLE>PRICEPROD</PRICEPRODTABLE>" +
                    "  <COUNTERPARTYTABLE>COUNTERPARTY</COUNTERPARTYTABLE>" +
                    "  <TYPECOUNTERPARTYTABLE>TYPECOUNTERPARTY</TYPECOUNTERPARTYTABLE>" +
                    "  <TYPESHOPTABLE>TYPESHOP</TYPESHOPTABLE>" +
                    "  <UNITPRODTABLE>UNIT</UNITPRODTABLE>" +
                    "  <SHOPTABLE>SHOP</SHOPTABLE>" +
                    "  <ORDERTABLE>ORDER</ORDERTABLE>" +
                    "  <PRODORDERTABLE>PRODORDER</PRODORDERTABLE>" +
                    "  <!--Related values of column names-->" +
                    "  <!--table - USERAPPTABLE-->" +
                    "  <IDUSER>id</IDUSER>" +
                    "  <IDEMPLOYEESPOSITIONFK>id_emp_pos</IDEMPLOYEESPOSITIONFK>" +
                    "  <SURNAMEUSER>surname</SURNAMEUSER>" +
                    "  <FIRSTNAMEUSER>firstname</FIRSTNAMEUSER>" +
                    "  <PATRONYMICUSER>patronymic</PATRONYMICUSER>" +
                    "  <PHONENUMBERUSER>number_phone</PHONENUMBERUSER>" +
                    "  <EMAILUSER>email</EMAILUSER>" +
                    "  <LOGINUSER>login_app</LOGINUSER>" +
                    "  <PASSWORDUSER>password_app</PASSWORDUSER>" +
                    "  <!--table - EMPPOSTABLE-->" +
                    "  <IDEMPPOS>id</IDEMPPOS>" +
                    "  <NAMEEMPPOS>name</NAMEEMPPOS>" +
                    "  <!--table - CATEGORYPRODTABLE-->" +
                    "  <IDCATEGORYPROD>id</IDCATEGORYPROD>" +
                    "  <NAMECATEGORYPROD>name</NAMECATEGORYPROD>" +
                    "  <!--table - PRODUCTTABLE-->" +
                    "  <NAMEGOODS>name</NAMEGOODS>" +
                    "  <IDCATEGORYPRODFK>id_category_prod</IDCATEGORYPRODFK>" +
                    "  <IDPROD>id</IDPROD>" +
                    "  <IDUNITFK>id_unit</IDUNITFK>" +
                    "  <OCCUPUIEDVOLUMEPROD>occupied_volume</OCCUPUIEDVOLUMEPROD>" +
                    "  <!--table - PRICEPRODTABLE-->" +
                    "  <IDPRODFK>id_prod</IDPRODFK>" +
                    "  <IDCOUNTERPARTYFK>id_counterparty</IDCOUNTERPARTYFK>" +
                    "  <PRICEPROD>price</PRICEPROD>" +
                    "  <!--table - COUNTERPARTYTABLE-->" +
                    "  <IDCOUNTERPARTY>id</IDCOUNTERPARTY>" +
                    "  <IDTYPECOUNTERPARTYFK>id_type_counterparty</IDTYPECOUNTERPARTYFK>" +
                    "  <NAMECOUNTERPARTY>name</NAMECOUNTERPARTY>" +
                    "  <INDEXCOUNTERPARTY>index</INDEXCOUNTERPARTY>" +
                    "  <LOCATIONCOUNTERPARTY>location</LOCATIONCOUNTERPARTY>" +
                    "  <STREETCOUNTERPARTY>street</STREETCOUNTERPARTY>" +
                    "  <BUILDINGCOUNTERPARTY>building</BUILDINGCOUNTERPARTY>" +
                    "  <HOUSECOUNTERPARTY>house</HOUSECOUNTERPARTY>" +
                    "  <OFFICECOUNTERPARTY>office</OFFICECOUNTERPARTY>" +
                    "  <INNCOUNTERPARTY>INN</INNCOUNTERPARTY>" +
                    "  <BICCOUNTERPARTY>BIC</BICCOUNTERPARTY>" +
                    "  <NUMBERPHONECOUNTERPARTY>number_phone</NUMBERPHONECOUNTERPARTY>" +
                    "  <EMAILCOUNTERPARTY>email</EMAILCOUNTERPARTY>" +
                    "  <MINVOLUMECARRIER>min_volume</MINVOLUMECARRIER>" +
                    "  <MAXVOLUMECARRIER>max_volume</MAXVOLUMECARRIER>" +
                    "  <!--table - TYPECOUNTERPARTYTABLE-->" +
                    "  <IDTYPECOUNTERPARTY>id</IDTYPECOUNTERPARTY>" +
                    "  <NAMETYPECOUNTERPARTY>name</NAMETYPECOUNTERPARTY>" +
                    "  <!--table - TYPESHOPTABLE-->" +
                    "  <IDTYPESHOP>id</IDTYPESHOP>" +
                    "  <NAMETYPESHOP>name</NAMETYPESHOP>" +
                    "  <!--table - UNITPRODTABLE-->" +
                    "  <IDUNIT>id</IDUNIT>" +
                    "  <NAMEUNIT>name</NAMEUNIT>" +
                    "  <!--table - SHOPTABLE-->" +
                    "  <IDSHOP>id</IDSHOP>" +
                    "  <IDTYPESHOPFK>id_type_shop</IDTYPESHOPFK>" +
                    "  <LOCATIONSHOP>location</LOCATIONSHOP>" +
                    "  <STREETSHOP>street</STREETSHOP>" +
                    "  <BUILDINGSHOP>building</BUILDINGSHOP>" +
                    "  <HOUSESHOP>house</HOUSESHOP>" +
                    "  <NAMESHOP>name</NAMESHOP>" +
                    "  <!--Number of returned values from the database (number of orders, number of products in the order)-->" +
                    "  <ROWSRECEIVED>100</ROWSRECEIVED>" +
                    "</Root>");

                try
                {
                    config.Save("config.xml");
                    return 0;
                }
                catch
                {
                    return -1;
                }  
            }
        }
    }
}
