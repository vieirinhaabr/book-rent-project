namespace Booker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBooks : DbMigration
    {
        public override void Up()
        {
            
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('Classical Mythology','Mark P. O. Morford',2002, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('Clara Callan','Richard Bruce Wright',2001, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('Decision in Normandy','Carlo D''Este',1991, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('Flu: The Story of the Great Influenza Pandemic of 1918 and the Search for the Virus That Caused It','Gina Bari Kolata',1999, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('The Mummies of Urumchi','E. J. W. Barber',1999, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('The Kitchen God''s Wife','Amy Tan',1991, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('What If?: The World''s Foremost Military Historians Imagine What Might Have Been','Robert Cowley',2000, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('PLEADING GUILTY','Scott Turow',1993, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('Under the Black Flag: The Romance and the Reality of Life Among the Pirates','David Cordingly',1996, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('Where You''ll Find Me: And Other Stories','Ann Beattie',2002, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('Nights Below Station Street','David Adams Richards',1988, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('Hitler''s Secret Bankers: The Myth of Swiss Neutrality During the Holocaust','Adam Lebor',2000, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('The Middle Stories','Sheila Heti',2004, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('Jane Doe','R. J. Kaiser',1999, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('A Second Chicken Soup for the Woman''s Soul (Chicken Soup for the Soul Series)','Jack Canfield',1998, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('The Witchfinder (Amos Walker Mystery Series)','Loren D. Estleman',1998, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('More Cunning Than Man: A Social History of Rats and Man','Robert Hendrickson',1999, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('Goodbye to the Buttermilk Sky','Julia Oliver',1994, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('The Testament','John Grisham',1999, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('Beloved (Plume Contemporary Fiction)','Toni Morrison',1994, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('Our Dumb Century: The Onion Presents 100 Years of Headlines from America''s Finest News Source','The Onion',1999, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('New Vegetarian: Bold and Beautiful Recipes for Every Occasion','Celia Brooks Brown',2001, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('If I''d Known Then What I Know Now: Why Not Learn from the Mistakes of Others? : You Can''t Afford to Make Them All Yourself','J. R. Parrish',2003, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('Mary-Kate &amp; Ashley Switching Goals (Mary-Kate and Ashley Starring in)','Mary-Kate &amp; Ashley Olsen',2000, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('Tell Me This Isn''t Happening','Robynn Clairday',1999, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('Flood : Mississippi 1927','Kathleen Duey',1998, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('Wild Animus','Rich Shapero',2004, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('Airframe','Michael Crichton',1997, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('Timeline','MICHAEL CRICHTON',2000, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('OUT OF THE SILENT PLANET','C.S. Lewis',1996, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('Prague : A Novel','ARTHUR PHILLIPS',2003, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('Chocolate Jesus','Stephan Jaramillo',1998, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('Wie Barney es sieht.','Mordecai Richler',2002, 0, 0)");
            Sql("INSERT INTO Books (Title, Author, YearOfPublication, NumberInStock, NumberRented) VALUES ('Der Fluch der Kaiserin. Ein Richter- Di- Roman.','Eleanor Cooney',2001, 0, 0)");

        }
        
        public override void Down()
        {
        }
    }
}
