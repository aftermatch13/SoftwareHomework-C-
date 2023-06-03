using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Order
{
    public class Users
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public Users()
        {
        }

        public Users(string id, string name)
        {
            ID = id;
            Name = name;
        }

        public override bool Equals(object obj)
        {
            var customer = obj as Users;
            return customer != null &&
                   ID == customer.ID &&
                   Name == customer.Name;
        }

        public override int GetHashCode()
        {
            var hashCode = 1524862488;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }
    public class Goods
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Goods()
        {
        }

        public Goods(string id, string name, double price)
        {
            ID = id;
            Name = name;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            var goods = obj as Goods;
            return goods != null &&
                   ID == goods.ID &&
                   Name == goods.Name;
        }

        public override int GetHashCode()
        {
            var hashCode = 1479869798;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }
    public class Order : IComparable<Order>
    {

        private List<OrderDetail> details;

        public int OrderId { get; set; }

        public Users Users { get; set; }

        public string UsersName { get => (Users != null) ? Users.Name : ""; }

        public DateTime CreateTime { get; set; }


        public Order() { details = new List<OrderDetail>(); CreateTime = DateTime.Now; }

        public Order(int orderId, Users customer, List<OrderDetail> items)
        {
            this.OrderId = orderId;
            this.Users = customer;
            this.CreateTime = DateTime.Now;
            this.details = (items == null) ? new List<OrderDetail>() : items;
        }

        public List<OrderDetail> Details
        {
            get { return details; }
        }

        public double TotalPrice
        {
            get => details.Sum(item => item.TotalPrice);
        }

        public void AddItem(OrderDetail orderItem)
        {
            if (Details.Contains(orderItem))
                throw new ApplicationException("订单项{orderItem.GoodsName} 已经存在!");
            Details.Add(orderItem);
        }

        public void RemoveDetail(OrderDetail orderItem)
        {
            Details.Remove(orderItem);
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append($"Id:{OrderId}, customer:{Users},orderTime:{CreateTime},totalPrice：{TotalPrice}");
            details.ForEach(od => strBuilder.Append("\n\t" + od));
            return strBuilder.ToString();
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null &&
                   OrderId == order.OrderId;
        }

        public override int GetHashCode()
        {
            var hashCode = -531220479;
            hashCode = hashCode * -1521134295 + OrderId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(UsersName);
            hashCode = hashCode * -1521134295 + CreateTime.GetHashCode();
            return hashCode;
        }

        public int CompareTo(Order other)
        {
            if (other == null) return 1;
            return this.OrderId.CompareTo(other.OrderId);
        }
    }
    public class OrderDetail
    {

        public int Index { get; set; } 

        public Goods GoodsItem { get; set; }

        public String GoodsName { get => GoodsItem != null ? this.GoodsItem.Name : ""; }

        public double UnitPrice { get => GoodsItem != null ? this.GoodsItem.Price : 0.0; }


        public int Quantity { get; set; }

        public OrderDetail() { }

        public OrderDetail(int index, Goods goods, int quantity)
        {
            this.Index = index;
            this.GoodsItem = goods;
            this.Quantity = quantity;
        }

        public double TotalPrice
        {
            get => GoodsItem == null ? 0.0 : GoodsItem.Price * Quantity;
        }

        public override string ToString()
        {
            return "[No.:{Index},goods:{GoodsName},quantity:{Quantity},totalPrice:{TotalPrice}]";
        }

        public override bool Equals(object obj)
        {
            var item = obj as OrderDetail;
            return item != null &&
                   GoodsName == item.GoodsName;
        }

        public override int GetHashCode()
        {
            var hashCode = -1847516859;
            hashCode = hashCode * -1521134295 + Index.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodsName);
            hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
            return hashCode;
        }
    }
    public class OrderService
    {

        //the order list
        private List<Order> orders;


        public OrderService()
        {
            orders = new List<Order>();
        }


        public List<Order> GetAllOrders()
        {
            return orders;
        }


        public Order GetOrder(int id)
        {
            return orders.Where(o => o.OrderId == id).FirstOrDefault();
        }

        public void AddOrder(Order order)
        {
            if (orders.Contains(order))
                throw new ApplicationException("订单{order.OrderId} 已经存在了!");
            orders.Add(order);
        }

        public void RemoveOrder(int orderId)
        {
            Order order = GetOrder(orderId);
            if (order != null)
            {
                orders.Remove(order);
            }
        }

        public List<Order> QueryOrdersByGoodsName(string goodsName)
        {
            var query = orders
                    .Where(order => order.Details.Exists(item => item.GoodsName == goodsName))
                    .OrderBy(o => o.TotalPrice);
            return query.ToList();
        }

        public List<Order> QueryOrdersByUsersName(string customerName)
        {
            return orders
                .Where(order => order.UsersName == customerName)
                .OrderBy(o => o.TotalPrice)
                .ToList();
        }

        public void UpdateOrder(Order newOrder)
        {
            Order oldOrder = GetOrder(newOrder.OrderId);
            if (oldOrder == null)
                throw new ApplicationException("订单 {newOrder.OrderId} 不存在!");
            orders.Remove(oldOrder);
            orders.Add(newOrder);
        }

        public void Export(String fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xs.Serialize(fs, orders);
            }
        }

        public void Import(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> temp = (List<Order>)xs.Deserialize(fs);
                temp.ForEach(order => {
                    if (!orders.Contains(order))
                    {
                        orders.Add(order);
                    }
                });
            }
        }

        public object QueryByTotalAmount(float amout)
        {
            return orders
               .Where(order => order.TotalPrice >= amout)
               .OrderByDescending(o => o.TotalPrice)
               .ToList();
        }
    }
}
