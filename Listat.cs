using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Listat
{
    public static void Main()
    {
           List<string> sanat = new List<string> { "susi", "kissa", "kissa", "kana", "koira", "mato", "täi", "kissa" };
           Console.WriteLine(string.Join(" ", sanat));

           string pisin = EtsiPisin(sanat);
           Console.WriteLine(pisin);
           PoistaSanat(sanat, pisin);
           Console.WriteLine(string.Join(" ", sanat));
    }
    
    
    ///<summary>
    /// Aliohjelma etsii (ja palauttaa) pisimman sanan parametrina tuodusta sanalistasta
    ///</summary>
    ///<param name="sanat">sanalista</param>
    ///<example>
    ///<pre name ="test">
    ///List<string> sanat = new List<string>{"kana", "kissa", "koirakala", "kana", "purkkiruoka"};
    /// EtsiPisin(sanat) === "purkkiruoka";
    ///List<string> sanat2 = new List<string>{"kanalaatikko", "kissa", "koi", "kana", "purkki"};
    /// EtsiPisin(sanat2) === "kanalaatikko";
    ///List<string> sanat3 = new List<string>{"tieto", "kissa", "koira", "kana", "patteriruoka"};
    /// EtsiPisin(sanat3) === "patteriruoka";
    ///List<string> sanat4 = new List<string>{"tieto", "kissa", "koira", "kana", "patteri"};
    /// EtsiPisin(sanat4) === "patteri";
    ///</pre>
    ///</example>
    public static string EtsiPisin(List<string> sanat)
    {
        if (sanat.Count > 0)
        {
            string pisin = sanat[0];
            int pisimmanSananPituus = pisin.Length;
            
            for(int i = 1; i < sanat.Count; i++)
            {
                if (sanat[i].Length > pisimmanSananPituus) { pisin = sanat[i]; }
            }
            return pisin;
        }
        return "";
    }


    ///<summary>
    /// Aliohjelma poistaa parametrina tuodun poistettavan sanan parametrina tuodusta sanalistasta
    ///</summary>
    ///<param name="sanat">sanalista</param>
    ///<param name="poistettava">listasta poistettava sana</param>
    public static void PoistaSanat(List<string> sanat, string poistettava)
    {
        if (sanat.Count > 0)
        {
            for (int i = sanat.Count - 1; i >= 0; i--)
            {
                sanat.Remove(poistettava); 
            }
        }
    }
 }
