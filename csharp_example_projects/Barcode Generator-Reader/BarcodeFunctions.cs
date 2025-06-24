using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode.Generation;

namespace BarcodeFunctionsNS
{
    class Reader
    {
        public static void ReadBarcode(string filePath)
        {
            try
            {
                // Initialize the BarcodeReader
                BarCodeReader barcodeReader = new BarCodeReader();

                // Decode the barcode from the image file
                var result = barcodeReader.ReadBarCodes();

                // Check if a result was found
                if (result != null)
                {
                    foreach (var barcodeResult in result)
                    {
                        Console.WriteLine("Barcode Text: " + barcodeResult.CodeText);
                    }
                }
                else
                {
                    Console.WriteLine("No barcode found in the image.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while reading the barcode: " + ex.Message);
            }
        }
    }

    class Creator
    {
        public static void CreateBarcode(string barcodeText, string filePath)
        {
            try
            {
                filePath = filePath + ".eps";
                // Initialize the BarcodeGenerator with the required symbology and code text
                BarcodeGenerator barcodeGenerator = new BarcodeGenerator(EncodeTypes.Code128, barcodeText);

                // Set various properties if needed
                barcodeGenerator.Parameters.Barcode.XDimension.Pixels = 3; // Width of each bar
                barcodeGenerator.Parameters.Barcode.BarHeight.Pixels = 50; // Height of bars

                // Save the barcode image to the specified file path
                barcodeGenerator.Save(filePath, BarCodeImageFormat.Png);

                Console.WriteLine("Barcode created and saved to: " + filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while creating the barcode: " + ex.Message);
            }
        }
    }
}
