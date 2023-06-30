namespace DoAnIspace.Const
{
    public class BillConst
    {
    public int Bill_id { get; set; }
    public int User_id { get; set; }
    public int Bill_Count { get; set; }
    public string Bill_Total { get; set; }
    public bool Bill_Status { get; set; }
    }
    public class BillConstAdd
    {
        public int User_id { get; set; }
        public int Bill_Count { get; set; }
        public string Bill_Total { get; set; }
        public bool Bill_Status { get; set; }
    }
    public class BillProductConst
    {
        public int Bill_id { get; set; }
        public int Product_id { get; set; }
        public string Product_Price { get; set; }
        public int Size_id { get; set; }
    }
}
