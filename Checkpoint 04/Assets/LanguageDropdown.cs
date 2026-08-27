using UnityEngine;
using UnityEngine.Localization.Settings;

public class LanguageDropdown : MonoBehaviour
{
    public void MudarIdioma(int opcao)
    {
        if (opcao == 0)
        {
            LocalizationSettings.SelectedLocale =
                LocalizationSettings.AvailableLocales.GetLocale("pt-BR");
        }
        else if (opcao == 1)
        {
            LocalizationSettings.SelectedLocale =
                LocalizationSettings.AvailableLocales.GetLocale("en-US");
        }
        else if (opcao == 2)
        {
            LocalizationSettings.SelectedLocale =
                LocalizationSettings.AvailableLocales.GetLocale("es");
        }
        else if (opcao == 3)
        {
            LocalizationSettings.SelectedLocale =
                LocalizationSettings.AvailableLocales.GetLocale("ru-RU");
        }
    }
}