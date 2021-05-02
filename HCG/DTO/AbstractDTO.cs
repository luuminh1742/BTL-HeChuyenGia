namespace HCG.DTO
{
    class AbstractDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Id+" : "+Name+"\n";
        }
    }
}
