namespace HCG.DTO
{
    class MobileDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Screen { get; set; }
        public string Ram { get; set; }
        public string Camera { get; set; }
        public string Storage { get; set; }
        public string OperatingSystem { get; set; }

        public override string ToString()
        {
            return "Name: "+Name+
                "\nPrice: " +Price+
                "\nBrand: " +Brand+
                "\nColor: " + Color+
                "\nScreen: " +Screen+
                "\nRam: " +Ram+
                "\nCamera: " +Camera+
                "\nStorage: " +Storage+
                "\nOperating System: "+OperatingSystem;
        }
    }
}
