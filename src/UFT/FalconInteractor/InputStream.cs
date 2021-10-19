using System;

namespace Inputstream
{
	class InputStream:Falcon
    {
		
		
		public void InputNon(string inputreadonly) // The non-readable and accessable inputstream.Can only be used for accessing inputstream-non:edit
		{
                              
							   src.InputWrite i = new src.InputWrite(inputreadonly);
			       
		}
		public void InputEdit(string inputedit) // The editable inputstream which is later converted to Falcon::Input-!edit
		{
			
			Console.WriteLine(inputedit);
                        string inputread = inputedit;
			// If the text is altered by WritePad, WritePad will use a new inputstream which is a copy of this inputstream

		}

	}
}




