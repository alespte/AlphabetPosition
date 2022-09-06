using System.Text;

public static class Program
{
    public static string AlphabetPosition (string text){
        text = text.ToUpper();
        byte [] ascii_letters = Encoding.ASCII.GetBytes(text);
        text = "";

        for (int i = 0; i < ascii_letters.Length; i++)
        {
            int temp = (ascii_letters[i] - 64);
            string text_temp;
            if (temp <= 0 || temp > 26)
            {
                text_temp = " ";    
            }
            else
            {   
                text_temp = temp.ToString() + " ";
                text += text_temp;    
            }
            //Console.WriteLine(text);
        }
        Console.WriteLine(text);
        return text.Trim();
    }

    static void Main (string [] args){
        string text = ("");
        AlphabetPosition(text);
    }
    
}


