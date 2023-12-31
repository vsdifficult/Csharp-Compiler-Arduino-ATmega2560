using System;
using ArduinoUploader;
using ArduinoUploader.Hardware;
using ArduinoUploader.Hardware.Memory;

namespace ArduinoSketchUploaderExample
{
    class setup_
    {
        static void Main(string[] args)
        {
            // Путь к файлу скетча (.hex)
            var sketchPath = "C:\\path\\to\\your\\sketch.hex";
            
            // Выбор типа платы Arduino
            // Например, UNO или NANO
            var arduinoModel = ArduinoModel.Mega2560;
            
            // Подключение к Arduino
            using (var arduinoUploader = new ArduinoSketchUploader(arduinoModel, GetSerialPortName(), true))
            {
                // Загрузка скетча в Arduino
                arduinoUploader.UploadSketch(sketchPath, MemoryModel.Flash);
            }
        }

        private static string GetSerialPortName()
        {
            // Поиск порта, к которому подключена Arduino
          
            // Возвращаем имя порта
           return "COM4"; // Замените на правильное имя порта
        }
    }
}