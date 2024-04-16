using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Console.WriteLine("                             Windows Uygulama ve Ayar Yöneticisi");
                Console.WriteLine("                          Geliştirici Modu Aktif - İstediğiniz İşlemi Seçin");
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Console.WriteLine("  1. IP Yapılandırması         11. CMD Komutları                21. Disk Temizleme");
                Console.WriteLine("  2. Belgeler                  12. Klasör Yapısı                22. Tarayıcı Ayarları");
                Console.WriteLine("  3. Görev Zamanlayıcı         13. Sistem Yöneticisi            23. Geri Dönüşüm Kutusu");
                Console.WriteLine("  4. Klavye Ayarları           14. Yazıcı ve Tarayıcılar        24. Başlangıç Programları");
                Console.WriteLine("  5. Hesap Ayarları            15. Güvenlik Duvarı Ayarları     25. Ses Ayarları");
                Console.WriteLine("  6. Tema ve Ekran Koruyucu    16. Bilgisayar Yönetimi          26. Klavye ve Fare Ayarları");
                Console.WriteLine("  7. Dil ve Bölge Ayarları     17. Aygıt Yöneticisi             27. Ekran Çözünürlüğü");
                Console.WriteLine("  8. Uygulama Ayarları         18. Performans Ayarları          28. Ağ Ayarları");
                Console.WriteLine("  9. Güncelleme Ayarları       19. Erişim Kolaylığı             29. Enerji Ayarları");
                Console.WriteLine(" 10. Hesap Güvenliği           20. Depolama Ayarları            30. Revize Edilecek");
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Console.WriteLine();

                Console.Write("Lütfen yapmak istediğiniz işlemin numarasını girin (1-30): ");
                string secim = Console.ReadLine();
                Console.WriteLine();

                switch (secim)
                {
                    case "1":
                        Console.WriteLine("ipconfig");
                        break;
                    case "2":
                        System.Diagnostics.Process.Start("shell:DocumentsLibrary");
                        break;
                    case "3":
                        System.Diagnostics.Process.Start("control", "schedtasks");
                        break;
                    case "4":
                        System.Diagnostics.Process.Start("control", "/name Microsoft.Keyboard");
                        break;
                    case "5":
                        System.Diagnostics.Process.Start("control", "/name Microsoft.UserAccounts");
                        break;
                    case "6":
                        System.Diagnostics.Process.Start("control", "/name Microsoft.Personalization /page pageScreenSaver");
                        break;
                    case "7":
                        System.Diagnostics.Process.Start("control", "/name Microsoft.RegionAndLanguage");
                        break;
                    case "8":
                        System.Diagnostics.Process.Start("control", "/name Microsoft.DefaultPrograms");
                        break;
                    case "9":
                        System.Diagnostics.Process.Start("control", "/name Microsoft.WindowsUpdate");
                        break;
                    case "10":
                        System.Diagnostics.Process.Start("control", "/name Microsoft.BitLockerDriveEncryption");
                        break;
                    case "11":
                        System.Diagnostics.Process.Start("cmd");
                        break;
                    case "12":
                        System.Diagnostics.Process.Start("explorer.exe", "/e,C:\\Users\\" + Environment.UserName);
                        break;
                    case "13":
                        System.Diagnostics.Process.Start("control", "/name Microsoft.AdministrativeTools");
                        break;
                    case "14":
                        System.Diagnostics.Process.Start("control", "printers");
                        break;
                    case "15":
                        System.Diagnostics.Process.Start("control", "/name Microsoft.Firewall");
                        break;
                    case "16":
                        System.Diagnostics.Process.Start("control", "/name Microsoft.ComputerManagement");
                        break;
                    case "17":
                        System.Diagnostics.Process.Start("devmgmt.msc");
                        break;
                    case "18":
                        System.Diagnostics.Process.Start("sysdm.cpl");
                        break;
                    case "19":
                        System.Diagnostics.Process.Start("control", "/name Microsoft.EaseOfAccessCenter");
                        break;
                    case "20":
                        System.Diagnostics.Process.Start("control", "/name Microsoft.StorageSpaces");
                        break;
                    case "21":
                        System.Diagnostics.Process.Start("cleanmgr");
                        break;
                    case "22":
                        System.Diagnostics.Process.Start("control", "/name Microsoft.InternetOptions");
                        break;
                    case "23":
                        System.Diagnostics.Process.Start("shell:RecycleBinFolder");
                        break;
                    case "24":
                        System.Diagnostics.Process.Start("shell:startup");
                        break;
                    case "25":
                        System.Diagnostics.Process.Start("mmsys.cpl");
                        break;
                    case "26":
                        System.Diagnostics.Process.Start("control", "/name Microsoft.Mouse");
                        break;
                    case "27":
                        System.Diagnostics.Process.Start("desk.cpl");
                        break;
                    case "28":
                        System.Diagnostics.Process.Start("control", "/name Microsoft.NetworkAndSharingCenter");
                        break;
                    case "29":
                        System.Diagnostics.Process.Start("powercfg.cpl");
                        break;
                    case "30":
                        Console.WriteLine("Revizyon aşamasında.");
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim.");
                        break;
                }

                Console.Write("Başka bir işlem yapmak ister misiniz? (E/H): ");
                string devam = Console.ReadLine();
                if (devam.ToUpper() != "E")
                    break;
            }

            Console.WriteLine("İşlem tamamlandı. Program kapatılıyor...");
            System.Threading.Thread.Sleep(3000);
        }
    }
}
