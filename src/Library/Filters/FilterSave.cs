namespace CompAndDel.Filters
{

    public class FilterSave : IFilter
    {
        public IPicture Filter(IPicture image)
        {
            PictureProvider p = new PictureProvider();
            p.SavePicture(image,@"imagennueva.jpg");
            return image;
        }
    }
}