using System;
using System.Collections.Generic;
using System.Text;

public static class TrascrizioneRNA
{
    public static string ToRna(string dna)
    {
        string RNA = "";
        if( String.IsNullOrEmpty( dna ) )
            return "";
        
        else{
            char[] r = dna.ToCharArray();
            for (int i = 0; i < r.Length;i++){
                switch(r[i]){
                    case('A'):
                        r[i] = 'U';
                        break;
                    case('T'):
                        r[i] = 'A';
                        break;
                    case('G'):
                        r[i] = 'C';
                        break;
                    case('C'):
                        r[i] = 'G';
                        break;
                }
                RNA = RNA + Convert.ToString(r[i]);
            } 
            return RNA;
        }
           
    }
}