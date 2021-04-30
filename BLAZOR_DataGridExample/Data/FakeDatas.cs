using BLAZOR_DataGridExample.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLAZOR_DataGridExample.Data
{
    public static class FakeDatas
    {
        public static List<FakeDataModel> model = new List<FakeDataModel>
        {
            new FakeDataModel { Id = 1, Name = "Delbert Marvin", Address = "East Lauriane", PostCode = "76351", Phone = "981-929-7549", Email = "Delbert99@hotmail.com" },
            new FakeDataModel { Id = 2, Name = "Garry Witting", Address = "Sabinafurt", PostCode = "00496-6342", Phone = "(536) 937-5921", Email = "Garry_Witting38@hotmail.com" },
            new FakeDataModel { Id = 3, Name = "Nathan Schuster", Address = "Clemmieton", PostCode = "91060", Phone = "209-707-4145", Email = "Nathan.Schuster@gmail.com" },
            new FakeDataModel { Id = 4, Name = "Paulette Streich", Address = "Alvabury", PostCode = "48351", Phone = "(845) 393-9003 x31336", Email = "Paulette.Streich68@hotmail.com" },
            new FakeDataModel { Id = 5, Name = "Francis Grant", Address = "Cesarberg", PostCode = "59318", Phone = "(595) 418-8865 x6194", Email = "Francis21@yahoo.com" },
            new FakeDataModel { Id = 6, Name = "Delbert Hintz", Address = "Gussieton", PostCode = "68506-5583", Phone = "(836) 490-3849", Email = "Delbert.Hintz16@gmail.com" },
            new FakeDataModel { Id = 7, Name = "Johnnie Wintheiser", Address = "East Matt", PostCode = "60713", Phone = "309-352-9084 x65906", Email = "Johnnie.Wintheiser@yahoo.com" },
            new FakeDataModel { Id = 8, Name = "Desiree Predovic", Address = "Jarrettstad", PostCode = "17864-5239", Phone = "805.398.3583 x298", Email = "Desiree.Predovic64@gmail.com" },
            new FakeDataModel { Id = 9, Name = "Beverly VonRueden", Address = "Port Kade", PostCode = "75001", Phone = "402.845.6499 x3464", Email = "Beverly30@gmail.com" },
            new FakeDataModel { Id = 10, Name = "Pat Lakin", Address = "Schinnerburgh", PostCode = "66755-5315", Phone = "346-517-0452 x718", Email = "Pat.Lakin@gmail.com" },
            new FakeDataModel { Id = 11, Name = "Lawrence Erdman", Address = "Lebsackhaven", PostCode = "84188", Phone = "636.361.0338 x03226", Email = "Lawrence27@yahoo.com" },
            new FakeDataModel { Id = 12, Name = "Gwen Wehner", Address = "East Westonchester", PostCode = "83606", Phone = "994-585-5626 x37914", Email = "Gwen_Wehner52@hotmail.com" },
            new FakeDataModel { Id = 13, Name = "Julio Cassin", Address = "Jonesfurt", PostCode = "84343-1966", Phone = "444-908-7035 x660", Email = "Julio_Cassin64@hotmail.com" },
            new FakeDataModel { Id = 14, Name = "Tomas Leuschke", Address = "Cummeratamouth", PostCode = "18117-6854", Phone = "1-798-626-4394 x3909", Email = "Tomas48@yahoo.com" },
            new FakeDataModel { Id = 15, Name = "Glenn Welch", Address = "Osinskifurt", PostCode = "54779-8714", Phone = "308-875-9890 x91780", Email = "Glenn.Welch48@hotmail.com" },
            new FakeDataModel { Id = 16, Name = "Lynn Koepp", Address = "New Justus", PostCode = "17757", Phone = "423-434-6249 x773", Email = "Lynn_Koepp@hotmail.com" },
            new FakeDataModel { Id = 17, Name = "Aaron Gutmann", Address = "Bernieceborough", PostCode = "60344-0213", Phone = "1-493-756-6066 x640", Email = "Aaron64@yahoo.com" },
            new FakeDataModel { Id = 18, Name = "Mildred Purdy", Address = "Hahntown", PostCode = "71729-6712", Phone = "1-800-887-6333 x87952", Email = "Mildred7@hotmail.com" },
            new FakeDataModel { Id = 19, Name = "Mamie Gibson", Address = "North Rowanmouth", PostCode = "83938-3337", Phone = "(500) 808-9109 x7409", Email = "Mamie72@yahoo.com" },
            new FakeDataModel { Id = 20, Name = "Willard Renner", Address = "Revabury", PostCode = "93775-8352", Phone = "521.243.8421", Email = "Willard.Renner@yahoo.com" },
            new FakeDataModel { Id = 21, Name = "Malcolm Hilll", Address = "Kadehaven", PostCode = "99908", Phone = "1-958-504-1876 x694", Email = "Malcolm_Hilll58@gmail.com" },
            new FakeDataModel { Id = 22, Name = "Rosemarie Johns", Address = "Vincentfurt", PostCode = "41230-1230", Phone = "(456) 379-4982 x32163", Email = "Rosemarie_Johns32@yahoo.com" },
            new FakeDataModel { Id = 23, Name = "Floyd Stanton", Address = "East Laury", PostCode = "98772-3847", Phone = "(535) 331-4501 x3809", Email = "Floyd.Stanton43@gmail.com" },
            new FakeDataModel { Id = 24, Name = "Vanessa Mayert", Address = "Port Andreton", PostCode = "17406", Phone = "1-602-515-5637 x72568", Email = "Vanessa_Mayert@hotmail.com" },
            new FakeDataModel { Id = 25, Name = "Nicholas Stoltenberg", Address = "Kayaborough", PostCode = "01996", Phone = "714-408-4930 x9384", Email = "Nicholas.Stoltenberg4@hotmail.com" },
            new FakeDataModel { Id = 26, Name = "Lee Gleichner", Address = "Enochbury", PostCode = "53518", Phone = "1-872-883-0078", Email = "Lee92@hotmail.com" },
            new FakeDataModel { Id = 27, Name = "Delbert Marvin", Address = "East Lauriane", PostCode = "76351", Phone = "981-929-7549", Email = "Delbert99@hotmail.com" },
            new FakeDataModel { Id = 28, Name = "Garry Witting", Address = "Sabinafurt", PostCode = "00496-6342", Phone = "(536) 937-5921", Email = "Garry_Witting38@hotmail.com" },
            new FakeDataModel { Id = 29, Name = "Nathan Schuster", Address = "Clemmieton", PostCode = "91060", Phone = "209-707-4145", Email = "Nathan.Schuster@gmail.com" },
            new FakeDataModel { Id = 30, Name = "Paulette Streich", Address = "Alvabury", PostCode = "48351", Phone = "(845) 393-9003 x31336", Email = "Paulette.Streich68@hotmail.com" },
            new FakeDataModel { Id = 31, Name = "Francis Grant", Address = "Cesarberg", PostCode = "59318", Phone = "(595) 418-8865 x6194", Email = "Francis21@yahoo.com" },
            new FakeDataModel { Id = 32, Name = "Delbert Hintz", Address = "Gussieton", PostCode = "68506-5583", Phone = "(836) 490-3849", Email = "Delbert.Hintz16@gmail.com" },
            new FakeDataModel { Id = 33, Name = "Johnnie Wintheiser", Address = "East Matt", PostCode = "60713", Phone = "309-352-9084 x65906", Email = "Johnnie.Wintheiser@yahoo.com" },
            new FakeDataModel { Id = 34, Name = "Desiree Predovic", Address = "Jarrettstad", PostCode = "17864-5239", Phone = "805.398.3583 x298", Email = "Desiree.Predovic64@gmail.com" },
            new FakeDataModel { Id = 35, Name = "Beverly VonRueden", Address = "Port Kade", PostCode = "75001", Phone = "402.845.6499 x3464", Email = "Beverly30@gmail.com" },
            new FakeDataModel { Id = 36, Name = "Pat Lakin", Address = "Schinnerburgh", PostCode = "66755-5315", Phone = "346-517-0452 x718", Email = "Pat.Lakin@gmail.com" },
            new FakeDataModel { Id = 37, Name = "Lawrence Erdman", Address = "Lebsackhaven", PostCode = "84188", Phone = "636.361.0338 x03226", Email = "Lawrence27@yahoo.com" },
            new FakeDataModel { Id = 38, Name = "Gwen Wehner", Address = "East Westonchester", PostCode = "83606", Phone = "994-585-5626 x37914", Email = "Gwen_Wehner52@hotmail.com" },
            new FakeDataModel { Id = 39, Name = "Julio Cassin", Address = "Jonesfurt", PostCode = "84343-1966", Phone = "444-908-7035 x660", Email = "Julio_Cassin64@hotmail.com" },
            new FakeDataModel { Id = 40, Name = "Tomas Leuschke", Address = "Cummeratamouth", PostCode = "18117-6854", Phone = "1-798-626-4394 x3909", Email = "Tomas48@yahoo.com" },
            new FakeDataModel { Id = 41, Name = "Glenn Welch", Address = "Osinskifurt", PostCode = "54779-8714", Phone = "308-875-9890 x91780", Email = "Glenn.Welch48@hotmail.com" },
            new FakeDataModel { Id = 42, Name = "Lynn Koepp", Address = "New Justus", PostCode = "17757", Phone = "423-434-6249 x773", Email = "Lynn_Koepp@hotmail.com" },
            new FakeDataModel { Id = 43, Name = "Aaron Gutmann", Address = "Bernieceborough", PostCode = "60344-0213", Phone = "1-493-756-6066 x640", Email = "Aaron64@yahoo.com" },
            new FakeDataModel { Id = 44, Name = "Mildred Purdy", Address = "Hahntown", PostCode = "71729-6712", Phone = "1-800-887-6333 x87952", Email = "Mildred7@hotmail.com" },
            new FakeDataModel { Id = 45, Name = "Mamie Gibson", Address = "North Rowanmouth", PostCode = "83938-3337", Phone = "(500) 808-9109 x7409", Email = "Mamie72@yahoo.com" },
            new FakeDataModel { Id = 46, Name = "Willard Renner", Address = "Revabury", PostCode = "93775-8352", Phone = "521.243.8421", Email = "Willard.Renner@yahoo.com" },
            new FakeDataModel { Id = 47, Name = "Malcolm Hilll", Address = "Kadehaven", PostCode = "99908", Phone = "1-958-504-1876 x694", Email = "Malcolm_Hilll58@gmail.com" },
            new FakeDataModel { Id = 48, Name = "Rosemarie Johns", Address = "Vincentfurt", PostCode = "41230-1230", Phone = "(456) 379-4982 x32163", Email = "Rosemarie_Johns32@yahoo.com" },
            new FakeDataModel { Id = 49, Name = "Floyd Stanton", Address = "East Laury", PostCode = "98772-3847", Phone = "(535) 331-4501 x3809", Email = "Floyd.Stanton43@gmail.com" },
            new FakeDataModel { Id = 50, Name = "Vanessa Mayert", Address = "Port Andreton", PostCode = "17406", Phone = "1-602-515-5637 x72568", Email = "Vanessa_Mayert@hotmail.com" },
            new FakeDataModel { Id = 51, Name = "Nicholas Stoltenberg", Address = "Kayaborough", PostCode = "01996", Phone = "714-408-4930 x9384", Email = "Nicholas.Stoltenberg4@hotmail.com" },
            new FakeDataModel { Id = 52, Name = "Lee Gleichner", Address = "Enochbury", PostCode = "53518", Phone = "1-872-883-0078", Email = "Lee92@hotmail.com" }
        };
    };
    
}
