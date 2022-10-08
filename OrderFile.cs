using System.Xml;
using System.Text.RegularExpressions;

namespace LISGM
{
    internal class OrderFile
    {
        DataOrder dataOrder = new DataOrder();
        static DatabaseInteraction databaseInteraction = new DatabaseInteraction();

        string[][] goodsInOrder = new string[databaseInteraction.rowsReceived][];

        public OrderFile(DataOrder dataOrder, string[][] goodsInOrder)
        {
            this.dataOrder = dataOrder;
            this.goodsInOrder = goodsInOrder;
        }

        public int WritingToFile()
        {
            try
            {
                XmlDocument doc = new XmlDocument();

                XmlElement elemtRoot = doc.CreateElement("Root");
                doc.AppendChild(elemtRoot);

                XmlElement elemOrderID = doc.CreateElement("OrderID");
                elemOrderID.InnerText = dataOrder.id;
                elemtRoot.AppendChild(elemOrderID);

                XmlElement elemOrderDateStart = doc.CreateElement("DateStart");
                elemOrderDateStart.InnerText = dataOrder.dateStart;
                elemtRoot.AppendChild(elemOrderDateStart);

                if(dataOrder.dateEnd != "")
                {
                    XmlElement elemOrderDateEnd = doc.CreateElement("DateConfirm");
                    elemOrderDateEnd.InnerText = dataOrder.dateEnd;
                    elemtRoot.AppendChild(elemOrderDateEnd);
                }                

                XmlElement elemOrderManager = doc.CreateElement("Manager");
                XmlElement elemOrderManagerID = doc.CreateElement("ID");
                elemOrderManagerID.InnerText = dataOrder.idManager;
                elemOrderManager.AppendChild(elemOrderManagerID);
                elemtRoot.AppendChild(elemOrderManager);

                if(dataOrder.idSupplier != "")
                {
                    XmlElement elemOrderSupplier = doc.CreateElement("Supplier");
                    XmlElement elemOrderSupplierID = doc.CreateElement("ID");
                    elemOrderSupplierID.InnerText = dataOrder.idSupplier;
                    elemOrderSupplier.AppendChild(elemOrderSupplierID);
                    elemtRoot.AppendChild(elemOrderSupplier);
                }
                
                if(dataOrder.idLogistician != "")
                {
                    XmlElement elemOrderLogistician = doc.CreateElement("Logistician");
                    XmlElement elemOrderLogisticianID = doc.CreateElement("ID");
                    elemOrderLogisticianID.InnerText = dataOrder.idLogistician;
                    elemOrderLogistician.AppendChild(elemOrderLogisticianID);
                    elemtRoot.AppendChild(elemOrderLogistician);
                }
                
                if(dataOrder.idCarrier != "")
                {
                    XmlElement elemOrderCarrier = doc.CreateElement("Carrier");
                    XmlElement elemOrderCarrierID = doc.CreateElement("ID");
                    elemOrderCarrierID.InnerText = dataOrder.idCarrier;
                    elemOrderCarrier.AppendChild(elemOrderCarrierID);
                    elemtRoot.AppendChild(elemOrderCarrier);
                }                

                if(dataOrder.statusOrder != "")
                {
                    XmlElement elemStatusOrder = doc.CreateElement("StatusOrder");
                    elemStatusOrder.InnerText = dataOrder.statusOrder;
                    elemtRoot.AppendChild(elemStatusOrder);
                }
                
                if(dataOrder.statusDelivered != "")
                {
                    XmlElement elemStatusDelivered = doc.CreateElement("StatusDelivered");
                    elemStatusDelivered.InnerText = dataOrder.statusDelivered;
                    elemtRoot.AppendChild(elemStatusDelivered);
                }
                
                if(dataOrder.statusProcessOrder != "")
                {
                    XmlElement elemStatusProcessOrder = doc.CreateElement("StatusProcessOrder");
                    elemStatusProcessOrder.InnerText = dataOrder.statusProcessOrder;
                    elemtRoot.AppendChild(elemStatusProcessOrder);
                }              
                
                if(goodsInOrder[0] is not null)
                {
                    XmlElement elemtGoods = doc.CreateElement("Goods");
                    elemtRoot.AppendChild(elemtGoods);

                    for (int i = 0; goodsInOrder[i] is not null; i++)
                    {
                        XmlElement elemGoodsInOrder = doc.CreateElement("Goods" + (i + 1).ToString());

                        XmlElement elemGoodsInOrderID = doc.CreateElement("GoodsID");
                        elemGoodsInOrderID.InnerText = goodsInOrder[i][0];

                        XmlElement elemGoodsInOrderShopID = doc.CreateElement("ShopID");
                        elemGoodsInOrderShopID.InnerText = goodsInOrder[i][3];

                        Regex regexAmountOrd = new Regex(@"\.");
                        XmlElement elemGoodsInOrderAmountOrdered = doc.CreateElement("AmountOrdered");
                        elemGoodsInOrderAmountOrdered.InnerText = regexAmountOrd.Replace(goodsInOrder[i][6], ",");

                        Regex regexAmountDeliv = new Regex(@"\.");
                        XmlElement elemGoodsInOrderAmountDelivered = doc.CreateElement("AmountDelivered");
                        elemGoodsInOrderAmountDelivered.InnerText = regexAmountDeliv.Replace(goodsInOrder[i][7], ",");

                        elemGoodsInOrder.AppendChild(elemGoodsInOrderID);
                        elemGoodsInOrder.AppendChild(elemGoodsInOrderShopID);
                        elemGoodsInOrder.AppendChild(elemGoodsInOrderAmountOrdered);
                        elemGoodsInOrder.AppendChild(elemGoodsInOrderAmountDelivered);

                        elemtGoods.AppendChild(elemGoodsInOrder);
                    }
                }                

                doc.Save("data-current-order.xml");

                return 0;
            }
            catch
            {
                return -1;
            }            
        }
    }
}
