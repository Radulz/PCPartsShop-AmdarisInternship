using System;

namespace PCPartsShop.Models
{
    public abstract class Component
    {
        public Guid UniqueId { get; set; }
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }


        public Component(string make, string model)
        {
            Make = make;
            Model = model;
        }
        public Component()
        {
           
        }
    }
}
