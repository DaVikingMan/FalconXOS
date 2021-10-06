using System;

namespace Inputstream
{
	class InputStream:Falcon.Falcon
        {
		
		public void InputNon() // The non-readable and accessable inputstream.Can only be used for accessing inputstream-non:edit
		{
                       
		}
		public void InputEdit(string inputedit) // The editable inputstream which is later converted to Falcon::Input-!edit
		{
			
			Console.WriteLine(inputedit);
                        public readonly string inputread = inputedit; // Change to readonly as there is no use to alter the text.
			// If the text is altered by WritePad, WritePad will use a new inputstream which is a copy of this inputstream

		}

	}


}

