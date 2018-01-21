namespace SoftComputing.UTJ.BLL.Entities
{
    public class Field
    {
        public Field(string fieldContents)
        {
            string[] tokens = fieldContents.Split(':');

            if (tokens.Length == 1)
            {
                this.Type = "string";
                this.Name = tokens[0].Trim();
            }
            else if (tokens.Length > 1)
            {
                this.Type = tokens[0].Trim();
                this.Name = tokens[1].Trim();
            }
        }

        public string Name { get; set; }
        public string Type { get; set; }
    }
}
