using System;
using System.IO;

namespace Office2Pdf
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var fn in args)
            {
                try
                {
                    var ret = ConvertFile(fn);
                    Console.WriteLine("Output: {0} -> {1}", fn, ret);
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("File not found: {0}", fn);
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("Unsupported file: {0}", fn);
                }
            }
        }

        static bool IsOneOf<T>(T one, T[] coll)
        {
            foreach (var item in coll)
            {
                if (one.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        static string[] pptSuffix = { ".ppt", ".pptx" };
        static string[] docSuffix = { ".doc", ".docx" };
        static string ConvertFile(string fn)
        {
            if (!File.Exists(fn))
            {
                throw new FileNotFoundException();
            }
            var ext = Path.GetExtension(fn);
            IConverter converter;
            if (IsOneOf(ext, pptSuffix))
            {
                converter = new PowerPointConverter();
            }
            else if (IsOneOf(ext, docSuffix))
            {
                converter = new WordConverter();
            }
            else
            {
                throw new NotSupportedException();
            }
            string src = Path.GetFullPath(fn);
            string dst = Path.ChangeExtension(src, "pdf");
            converter.Convert2Pdf(src, dst);
            return Path.GetFileName(dst);
        }
    }
}
