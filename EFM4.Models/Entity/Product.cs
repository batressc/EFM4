namespace EFM4.Models.Entity {
    public class Product {
        public Product(string id, string name, string category, decimal unitPrice) {
            Id = id;
            Name = name;
            Category = category;
            UnitPrice = unitPrice;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
