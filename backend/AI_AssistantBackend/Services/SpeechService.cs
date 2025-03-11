using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

public class SpeechService
{
    public async Task<string> ConvertSpeechToText(string audioFilePath)
    {
        var process = new Process()
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "whisper", // Or another STT tool
                Arguments = audioFilePath,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            }
        };

        process.Start();
        string result = await process.StandardOutput.ReadToEndAsync();
        process.WaitForExit();

        return result.Trim();
    }
}
