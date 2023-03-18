using API.Classes;

namespace API.Entities
{
    public class Painting // each property represents a column in our Paintings table which we registered in StoreContext.cs 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public PaintingType Type {get; set;}
        public PaintingSubtype Subtype { get; set; }
        public string Dimensions { get; set; }
        public string YearCreated { get; set; }
        public byte[] ImageData { get; set; }
        public long OriginalPrice { get; set; }
        public bool IsOriginalAvailable { get; set; }
        public bool IsPrintAvailable { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public Painting(){
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
        }
    }
}