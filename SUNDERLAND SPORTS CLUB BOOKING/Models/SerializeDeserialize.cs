using SUNDERLAND_SPORTS_CLUB_BOOKING.Models;
using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public class SerializeDeserialize
{
	public SerializeDeserialize()
	{
	}

    public void Serialize(List<BookingClass> bk, String filename)
    {
         //Create the stream to add object into it.  
         //Format the object as Binary  

         BinaryFormatter formatter = new BinaryFormatter();



         try
         {
            Boolean nt = false;
            nt = File.Exists(filename);
            //FileStream ms = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            if (nt == true)
            {
               // ms.Close();
                //ms.Dispose();
                List<BookingClass> bookingClasses = new List<BookingClass>();
                bookingClasses = Deserialize(filename);

                FileStream md = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
              
                bookingClasses.AddRange(bk);
                foreach(BookingClass bookingClass in bookingClasses)
                {
                    formatter.Serialize(md, bookingClasses);
                }
            }
            else
            {
                FileStream ms = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                formatter.Serialize(ms, bk);
                
                ms.Flush();
                ms.Close();
                ms.Dispose();
                
            }
        }
         catch(Exception ex)
         {
             Console.WriteLine(ex.ToString());
         }

     }
     //Deserializing the List  
     public List<BookingClass> Deserialize(String filename)
     {
        List<BookingClass> bk = new List<BookingClass>();

         //Format the object as Binary  
         BinaryFormatter formatter = new BinaryFormatter();

         //Reading the file from the server  

         FileStream fs = File.Open(filename, FileMode.Open);

         bk = (List<BookingClass>)formatter.Deserialize(fs);
         fs.Flush();
         fs.Close();
         fs.Dispose();


        // for each statement below is meant to print out values from the object
        /*
                foreach (BookingClass bookingClass in bks)
                {
                    Response.Write(employee.Name + "<br/>");
                }*/

        return bk;
    }
}
