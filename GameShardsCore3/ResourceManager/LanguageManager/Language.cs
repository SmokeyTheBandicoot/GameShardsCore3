﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.ResourceManager.LanguageManager {

    public class Language {

        public string Name { get; set; }
        public string Culture { get; set; }
        public string SpecificCulture { get; set; }
        public string Country { get; set; }

        public Language(string name, string culture, string specificCulture, string country) {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Culture = culture ?? throw new ArgumentNullException(nameof(culture));
            SpecificCulture = specificCulture ?? throw new ArgumentNullException(nameof(specificCulture));
            Country = country ?? throw new ArgumentNullException(nameof(country));
        }

        /*public static Language Afrikaans { get { return new Language("Afrikaans", "af", "af-ZA", null); } }
        public static Language Afrikaans_ZA { get { return new Language("Afrikaans", "af-ZA", "af-ZA", "South Africa"); } }
        public static Language Arabic { get { return new Language("Arabics", "ar", "ar", null); } }
        public static Language Arabic_AE { get { return new Language("Arabic", "ar-AE", "ar-AE", "U.A.E."); } }
        public static Language Arabic_BH { get { return new Language("Arabic", "ar-BH", "ar-BH", "Bahrain"); } }
        public static Language Arabic_DZ { get { return new Language("Arabic", "ar-DZ", "ar-DZ", "Algeria"); } }
        public static Language Arabic_EG { get { return new Language("Arabic", "ar-EG", "ar-EG", "Egypt"); } }
        public static Language Arabic_IQ { get { return new Language("Arabic", "ar-IQ", "ar-IQ", "Iraq"); } }
        public static Language Arabic_JO { get { return new Language("Arabic", "ar-JO", "ar-JO", "Jordan"); } }
        public static Language Arabic_KW { get { return new Language("Arabic", "ar-KW", "ar-KW", "Kuwait"); } }
        public static Language Arabic_LB { get { return new Language("Arabic", "ar-LB", "ar-LB", "Lebanon"); } }
        public static Language Arabic_LY { get { return new Language("Arabic", "ar-LY", "ar-LY", "Libya"); } }
        public static Language Arabic_MA { get { return new Language("Arabic", "ar-MA", "ar-MA", "Morocco"); } }
        public static Language Arabic_OM { get { return new Language("Arabic", "ar-OM", "ar-OM", "Oman"); } }
        public static Language Arabic_QA { get { return new Language("Arabic", "ar-QA", "ar-QA", "Qatar"); } }
        public static Language Arabic_SA { get { return new Language("Arabic", "ar-SA", "ar-SA", "Saudi Arabia"); } }
        public static Language Arabic_SY { get { return new Language("Arabic", "ar-SY", "ar-SY", "Syria"); } }
        public static Language Arabic_TN { get { return new Language("Arabic", "ar-TN", "ar-TN", "Tunisia"); } }
        public static Language Arabic_YE { get { return new Language("Arabic", "ar-YE", "ar-YE", "Yemen"); } }
        public static Language Azeri { get { return new Language("Azeri", "az", "az-Latn-AZ", null); } }
        public static Language Azeri_Cyrl_AZ { get { return new Language("Azeri", "az-Cyrl-AZ", "az-Cyrl-AZ", "Azerbaijan (Cyrillic)"); } }
        public static Language Azeri_Latn_AZ { get { return new Language("Azeri", "az-Latn-AZ", "az-Latn-AZ", "Azerbaijan (Latin)"); } }
        public static Language Belarussian { get { return new Language("Belarussian", "be", "be-BY", null); } }
        public static Language Belarussian_BY { get { return new Language("Belarussian", "be-BY", "be-BY", "Belarus"); } }
        public static Language Bulgarian { get { return new Language("Bulgarian", "bg", "bg-BG", "Bulgaria"); } }
        public static Language Bulgarian_BG { get { return new Language("Bulgarian", "bg-BG", "bg-BG", "Bulgaria"); } }
        public static Language Bosnian { get { return new Language("Bosnian", "bs-Latn-BA", "bs-Latn-BA", "Bosnia and Herzegovina"); } }*/

    }
}

/*

bs-Latn-BA  bs-Latn-BA  Bosnian (Bosnia and Herzegovina)
ca          ca-ES       Catalan
ca-ES       ca-ES       Catalan (Catalan)
cs          cs-CZ       Czech
cs-CZ       cs-CZ       Czech (Czech Republic)
cy-GB       cy-GB       Welsh (United Kingdom)
da          da-DK       Danish
da-DK       da-DK       Danish (Denmark)
de          de-DE       German
de-AT       de-AT       German (Austria)
de-DE       de-DE       German (Germany)
de-CH       de-CH       German (Switzerland)
de-LI       de-LI       German (Liechtenstein)
de-LU       de-LU       German (Luxembourg)
dv          dv-MV       Divehi
dv-MV       dv-MV       Divehi (Maldives)
el          el-GR       Greek
el-GR       el-GR       Greek (Greece)
en          en-US       English
en-029      en-029      English (Caribbean)
en-AU       en-AU       English (Australia)
en-BZ       en-BZ       English (Belize)
en-CA       en-CA       English (Canada)
en-GB       en-GB       English (United Kingdom)
en-IE       en-IE       English (Ireland)
en-JM       en-JM       English (Jamaica)
en-NZ       en-NZ       English (New Zealand)
en-PH       en-PH       English (Republic of the Philippines)
en-TT       en-TT       English (Trinidad and Tobago)
en-US       en-US       English (United States)
en-ZA       en-ZA       English (South Africa)
en-ZW       en-ZW       English (Zimbabwe)
es          es-ES       Spanish
es-AR       es-AR       Spanish (Argentina)
es-BO       es-BO       Spanish (Bolivia)
es-CL       es-CL       Spanish (Chile)
es-CO       es-CO       Spanish (Colombia)
es-CR       es-CR       Spanish (Costa Rica)
es-DO       es-DO       Spanish (Dominican Republic)
es-EC       es-EC       Spanish (Ecuador)
es-ES       es-ES       Spanish (Spain)
es-GT       es-GT       Spanish (Guatemala)
es-HN       es-HN       Spanish (Honduras)
es-MX       es-MX       Spanish (Mexico)
es-NI       es-NI       Spanish (Nicaragua)
es-PA       es-PA       Spanish (Panama)
es-PE       es-PE       Spanish (Peru)
es-PR       es-PR       Spanish (Puerto Rico)
es-PY       es-PY       Spanish (Paraguay)
es-SV       es-SV       Spanish (El Salvador)
es-UY       es-UY       Spanish (Uruguay)
es-VE       es-VE       Spanish (Venezuela)
et          et-EE       Estonian
et-EE       et-EE       Estonian (Estonia)
eu          eu-ES       Basque
eu-ES       eu-ES       Basque (Basque)
fa          fa-IR       Persian
fa-IR       fa-IR       Persian (Iran)
fi          fi-FI       Finnish
fi-FI       fi-FI       Finnish (Finland)
fo          fo-FO       Faroese
fo-FO       fo-FO       Faroese (Faroe Islands)
fr          fr-FR       French
fr-BE       fr-BE       French (Belgium)
fr-CA       fr-CA       French (Canada)
fr-FR       fr-FR       French (France)
fr-CH       fr-CH       French (Switzerland)
fr-LU       fr-LU       French (Luxembourg)
fr-MC       fr-MC       French (Principality of Monaco)
gl          gl-ES       Galician
gl-ES       gl-ES       Galician (Galician)
gu          gu-IN       Gujarati
gu-IN       gu-IN       Gujarati (India)
he          he-IL       Hebrew
he-IL       he-IL       Hebrew (Israel)
hi          hi-IN       Hindi
hi-IN       hi-IN       Hindi (India)
hr          hr-HR       Croatian
hr-BA       hr-BA       Croatian (Bosnia and Herzegovina)
hr-HR       hr-HR       Croatian (Croatia)
hu          hu-HU       Hungarian
hu-HU       hu-HU       Hungarian (Hungary)
hy          hy-AM       Armenian
hy-AM       hy-AM       Armenian (Armenia)
id          id-ID       Indonesian
id-ID       id-ID       Indonesian (Indonesia)
is          is-IS       Icelandic
is-IS       is-IS       Icelandic (Iceland)
it          it-IT       Italian
it-CH       it-CH       Italian (Switzerland)
it-IT       it-IT       Italian (Italy)
ja          ja-JP       Japanese
ja-JP       ja-JP       Japanese (Japan)
ka          ka-GE       Georgian
ka-GE       ka-GE       Georgian (Georgia)
kk          kk-KZ       Kazakh
kk-KZ       kk-KZ       Kazakh (Kazakhstan)
kn          kn-IN       Kannada
kn-IN       kn-IN       Kannada (India)
ko          ko-KR       Korean
kok         kok-IN      Konkani
kok-IN      kok-IN      Konkani (India)
ko-KR       ko-KR       Korean (Korea)
ky          ky-KG       Kyrgyz
ky-KG       ky-KG       Kyrgyz (Kyrgyzstan)
lt          lt-LT       Lithuanian
lt-LT       lt-LT       Lithuanian (Lithuania)
lv          lv-LV       Latvian
lv-LV       lv-LV       Latvian (Latvia)
mi-NZ       mi-NZ       Maori (New Zealand)
mk          mk-MK       Macedonian
mk-MK       mk-MK       Macedonian (Former Yugoslav Republic of Macedonia)
mn          mn-MN       Mongolian
mn-MN       mn-MN       Mongolian (Cyrillic, Mongolia)
mr          mr-IN       Marathi
mr-IN       mr-IN       Marathi (India)
ms          ms-MY       Malay
ms-BN       ms-BN       Malay (Brunei Darussalam)
ms-MY       ms-MY       Malay (Malaysia)
mt-MT       mt-MT       Maltese (Malta)
nb-NO       nb-NO       Norwegian, Bokmal (Norway)
nl          nl-NL       Dutch
nl-BE       nl-BE       Dutch (Belgium)
nl-NL       nl-NL       Dutch (Netherlands)
nn-NO       nn-NO       Norwegian, Nynorsk (Norway)
no          nb-NO       Norwegian
ns-ZA       ns-ZA       Northern Sotho (South Africa)
pa          pa-IN       Punjabi
pa-IN       pa-IN       Punjabi (India)
pl          pl-PL       Polish
pl-PL       pl-PL       Polish (Poland)
pt          pt-BR       Portuguese
pt-BR       pt-BR       Portuguese (Brazil)
pt-PT       pt-PT       Portuguese (Portugal)
quz-BO      quz-BO      Quechua (Bolivia)
quz-EC      quz-EC      Quechua (Ecuador)
quz-PE      quz-PE      Quechua (Peru)
ro          ro-RO       Romanian
ro-RO       ro-RO       Romanian (Romania)
ru          ru-RU       Russian
ru-RU       ru-RU       Russian (Russia)
sa          sa-IN       Sanskrit
sa-IN       sa-IN       Sanskrit (India)
se-FI       se-FI       Sami (Northern) (Finland)
se-NO       se-NO       Sami (Northern) (Norway)
se-SE       se-SE       Sami (Northern) (Sweden)
sk          sk-SK       Slovak
sk-SK       sk-SK       Slovak (Slovakia)
sl          sl-SI       Slovenian
sl-SI       sl-SI       Slovenian (Slovenia)
sma-NO      sma-NO      Sami (Southern) (Norway)
sma-SE      sma-SE      Sami (Southern) (Sweden)
smj-NO      smj-NO      Sami (Lule) (Norway)
smj-SE      smj-SE      Sami (Lule) (Sweden)
smn-FI      smn-FI      Sami (Inari) (Finland)
sms-FI      sms-FI      Sami (Skolt) (Finland)
sq          sq-AL       Albanian
sq-AL       sq-AL       Albanian (Albania)
sr          sr-Latn-CS  Serbian
sr-Cyrl-BA  sr-Cyrl-BA  Serbian (Cyrillic) (Bosnia and Herzegovina)
sr-Cyrl-CS  sr-Cyrl-CS  Serbian (Cyrillic, Serbia)
sr-Latn-BA  sr-Latn-BA  Serbian (Latin) (Bosnia and Herzegovina)
sr-Latn-CS  sr-Latn-CS  Serbian (Latin, Serbia)
sv          sv-SE       Swedish
sv-FI       sv-FI       Swedish (Finland)
sv-SE       sv-SE       Swedish (Sweden)
sw          sw-KE       Kiswahili
sw-KE       sw-KE       Kiswahili (Kenya)
syr         syr-SY      Syriac
syr-SY      syr-SY      Syriac (Syria)
ta          ta-IN       Tamil
ta-IN       ta-IN       Tamil (India)
te          te-IN       Telugu
te-IN       te-IN       Telugu (India)
th          th-TH       Thai
th-TH       th-TH       Thai (Thailand)
tn-ZA       tn-ZA       Tswana (South Africa)
tr          tr-TR       Turkish
tr-TR       tr-TR       Turkish (Turkey)
tt          tt-RU       Tatar
tt-RU       tt-RU       Tatar (Russia)
uk          uk-UA       Ukrainian
uk-UA       uk-UA       Ukrainian (Ukraine)
ur          ur-PK       Urdu
ur-PK       ur-PK       Urdu (Islamic Republic of Pakistan)
uz          uz-Latn-UZ  Uzbek
uz-Cyrl-UZ  uz-Cyrl-UZ  Uzbek (Cyrillic, Uzbekistan)
uz-Latn-UZ  uz-Latn-UZ  Uzbek (Latin, Uzbekistan)
vi          vi-VN       Vietnamese
vi-VN       vi-VN       Vietnamese (Vietnam)
xh-ZA       xh-ZA       Xhosa (South Africa)
zh-CN       zh-CN       Chinese (People's Republic of China)
zh-HK       zh-HK       Chinese (Hong Kong S.A.R.)
zh-CHS      (none)      Chinese (Simplified)
zh-CHT      (none)      Chinese (Traditional)
zh-MO       zh-MO       Chinese (Macao S.A.R.)
zh-SG       zh-SG       Chinese (Singapore)
zh-TW       zh-TW       Chinese (Taiwan)
zu-ZA       zu-ZA       Zulu (South Africa)
 */









/* CULTURE   SPEC.CULTURE  ENGLISH NAME
--------------------------------------------------------------
                    Invariant Language (Invariant Country)
af          af-ZA       Afrikaans
af-ZA       af-ZA       Afrikaans (South Africa)
ar          ar-SA       Arabic
ar-AE       ar-AE       Arabic (U.A.E.)
ar-BH       ar-BH       Arabic (Bahrain)
ar-DZ       ar-DZ       Arabic (Algeria)
ar-EG       ar-EG       Arabic (Egypt)
ar-IQ       ar-IQ       Arabic (Iraq)
ar-JO       ar-JO       Arabic (Jordan)
ar-KW       ar-KW       Arabic (Kuwait)
ar-LB       ar-LB       Arabic (Lebanon)
ar-LY       ar-LY       Arabic (Libya)
ar-MA       ar-MA       Arabic (Morocco)
ar-OM       ar-OM       Arabic (Oman)
ar-QA       ar-QA       Arabic (Qatar)
ar-SA       ar-SA       Arabic (Saudi Arabia)
ar-SY       ar-SY       Arabic (Syria)
ar-TN       ar-TN       Arabic (Tunisia)
ar-YE       ar-YE       Arabic (Yemen)
az          az-Latn-AZ  Azeri
az-Cyrl-AZ  az-Cyrl-AZ  Azeri (Cyrillic, Azerbaijan)
az-Latn-AZ  az-Latn-AZ  Azeri (Latin, Azerbaijan)
be          be-BY       Belarusian
be-BY       be-BY       Belarusian (Belarus)
bg          bg-BG       Bulgarian
bg-BG       bg-BG       Bulgarian (Bulgaria)
bs-Latn-BA  bs-Latn-BA  Bosnian (Bosnia and Herzegovina)
ca          ca-ES       Catalan
ca-ES       ca-ES       Catalan (Catalan)
cs          cs-CZ       Czech
cs-CZ       cs-CZ       Czech (Czech Republic)
cy-GB       cy-GB       Welsh (United Kingdom)
da          da-DK       Danish
da-DK       da-DK       Danish (Denmark)
de          de-DE       German
de-AT       de-AT       German (Austria)
de-DE       de-DE       German (Germany)
de-CH       de-CH       German (Switzerland)
de-LI       de-LI       German (Liechtenstein)
de-LU       de-LU       German (Luxembourg)
dv          dv-MV       Divehi
dv-MV       dv-MV       Divehi (Maldives)
el          el-GR       Greek
el-GR       el-GR       Greek (Greece)
en          en-US       English
en-029      en-029      English (Caribbean)
en-AU       en-AU       English (Australia)
en-BZ       en-BZ       English (Belize)
en-CA       en-CA       English (Canada)
en-GB       en-GB       English (United Kingdom)
en-IE       en-IE       English (Ireland)
en-JM       en-JM       English (Jamaica)
en-NZ       en-NZ       English (New Zealand)
en-PH       en-PH       English (Republic of the Philippines)
en-TT       en-TT       English (Trinidad and Tobago)
en-US       en-US       English (United States)
en-ZA       en-ZA       English (South Africa)
en-ZW       en-ZW       English (Zimbabwe)
es          es-ES       Spanish
es-AR       es-AR       Spanish (Argentina)
es-BO       es-BO       Spanish (Bolivia)
es-CL       es-CL       Spanish (Chile)
es-CO       es-CO       Spanish (Colombia)
es-CR       es-CR       Spanish (Costa Rica)
es-DO       es-DO       Spanish (Dominican Republic)
es-EC       es-EC       Spanish (Ecuador)
es-ES       es-ES       Spanish (Spain)
es-GT       es-GT       Spanish (Guatemala)
es-HN       es-HN       Spanish (Honduras)
es-MX       es-MX       Spanish (Mexico)
es-NI       es-NI       Spanish (Nicaragua)
es-PA       es-PA       Spanish (Panama)
es-PE       es-PE       Spanish (Peru)
es-PR       es-PR       Spanish (Puerto Rico)
es-PY       es-PY       Spanish (Paraguay)
es-SV       es-SV       Spanish (El Salvador)
es-UY       es-UY       Spanish (Uruguay)
es-VE       es-VE       Spanish (Venezuela)
et          et-EE       Estonian
et-EE       et-EE       Estonian (Estonia)
eu          eu-ES       Basque
eu-ES       eu-ES       Basque (Basque)
fa          fa-IR       Persian
fa-IR       fa-IR       Persian (Iran)
fi          fi-FI       Finnish
fi-FI       fi-FI       Finnish (Finland)
fo          fo-FO       Faroese
fo-FO       fo-FO       Faroese (Faroe Islands)
fr          fr-FR       French
fr-BE       fr-BE       French (Belgium)
fr-CA       fr-CA       French (Canada)
fr-FR       fr-FR       French (France)
fr-CH       fr-CH       French (Switzerland)
fr-LU       fr-LU       French (Luxembourg)
fr-MC       fr-MC       French (Principality of Monaco)
gl          gl-ES       Galician
gl-ES       gl-ES       Galician (Galician)
gu          gu-IN       Gujarati
gu-IN       gu-IN       Gujarati (India)
he          he-IL       Hebrew
he-IL       he-IL       Hebrew (Israel)
hi          hi-IN       Hindi
hi-IN       hi-IN       Hindi (India)
hr          hr-HR       Croatian
hr-BA       hr-BA       Croatian (Bosnia and Herzegovina)
hr-HR       hr-HR       Croatian (Croatia)
hu          hu-HU       Hungarian
hu-HU       hu-HU       Hungarian (Hungary)
hy          hy-AM       Armenian
hy-AM       hy-AM       Armenian (Armenia)
id          id-ID       Indonesian
id-ID       id-ID       Indonesian (Indonesia)
is          is-IS       Icelandic
is-IS       is-IS       Icelandic (Iceland)
it          it-IT       Italian
it-CH       it-CH       Italian (Switzerland)
it-IT       it-IT       Italian (Italy)
ja          ja-JP       Japanese
ja-JP       ja-JP       Japanese (Japan)
ka          ka-GE       Georgian
ka-GE       ka-GE       Georgian (Georgia)
kk          kk-KZ       Kazakh
kk-KZ       kk-KZ       Kazakh (Kazakhstan)
kn          kn-IN       Kannada
kn-IN       kn-IN       Kannada (India)
ko          ko-KR       Korean
kok         kok-IN      Konkani
kok-IN      kok-IN      Konkani (India)
ko-KR       ko-KR       Korean (Korea)
ky          ky-KG       Kyrgyz
ky-KG       ky-KG       Kyrgyz (Kyrgyzstan)
lt          lt-LT       Lithuanian
lt-LT       lt-LT       Lithuanian (Lithuania)
lv          lv-LV       Latvian
lv-LV       lv-LV       Latvian (Latvia)
mi-NZ       mi-NZ       Maori (New Zealand)
mk          mk-MK       Macedonian
mk-MK       mk-MK       Macedonian (Former Yugoslav Republic of Macedonia)
mn          mn-MN       Mongolian
mn-MN       mn-MN       Mongolian (Cyrillic, Mongolia)
mr          mr-IN       Marathi
mr-IN       mr-IN       Marathi (India)
ms          ms-MY       Malay
ms-BN       ms-BN       Malay (Brunei Darussalam)
ms-MY       ms-MY       Malay (Malaysia)
mt-MT       mt-MT       Maltese (Malta)
nb-NO       nb-NO       Norwegian, Bokmal (Norway)
nl          nl-NL       Dutch
nl-BE       nl-BE       Dutch (Belgium)
nl-NL       nl-NL       Dutch (Netherlands)
nn-NO       nn-NO       Norwegian, Nynorsk (Norway)
no          nb-NO       Norwegian
ns-ZA       ns-ZA       Northern Sotho (South Africa)
pa          pa-IN       Punjabi
pa-IN       pa-IN       Punjabi (India)
pl          pl-PL       Polish
pl-PL       pl-PL       Polish (Poland)
pt          pt-BR       Portuguese
pt-BR       pt-BR       Portuguese (Brazil)
pt-PT       pt-PT       Portuguese (Portugal)
quz-BO      quz-BO      Quechua (Bolivia)
quz-EC      quz-EC      Quechua (Ecuador)
quz-PE      quz-PE      Quechua (Peru)
ro          ro-RO       Romanian
ro-RO       ro-RO       Romanian (Romania)
ru          ru-RU       Russian
ru-RU       ru-RU       Russian (Russia)
sa          sa-IN       Sanskrit
sa-IN       sa-IN       Sanskrit (India)
se-FI       se-FI       Sami (Northern) (Finland)
se-NO       se-NO       Sami (Northern) (Norway)
se-SE       se-SE       Sami (Northern) (Sweden)
sk          sk-SK       Slovak
sk-SK       sk-SK       Slovak (Slovakia)
sl          sl-SI       Slovenian
sl-SI       sl-SI       Slovenian (Slovenia)
sma-NO      sma-NO      Sami (Southern) (Norway)
sma-SE      sma-SE      Sami (Southern) (Sweden)
smj-NO      smj-NO      Sami (Lule) (Norway)
smj-SE      smj-SE      Sami (Lule) (Sweden)
smn-FI      smn-FI      Sami (Inari) (Finland)
sms-FI      sms-FI      Sami (Skolt) (Finland)
sq          sq-AL       Albanian
sq-AL       sq-AL       Albanian (Albania)
sr          sr-Latn-CS  Serbian
sr-Cyrl-BA  sr-Cyrl-BA  Serbian (Cyrillic) (Bosnia and Herzegovina)
sr-Cyrl-CS  sr-Cyrl-CS  Serbian (Cyrillic, Serbia)
sr-Latn-BA  sr-Latn-BA  Serbian (Latin) (Bosnia and Herzegovina)
sr-Latn-CS  sr-Latn-CS  Serbian (Latin, Serbia)
sv          sv-SE       Swedish
sv-FI       sv-FI       Swedish (Finland)
sv-SE       sv-SE       Swedish (Sweden)
sw          sw-KE       Kiswahili
sw-KE       sw-KE       Kiswahili (Kenya)
syr         syr-SY      Syriac
syr-SY      syr-SY      Syriac (Syria)
ta          ta-IN       Tamil
ta-IN       ta-IN       Tamil (India)
te          te-IN       Telugu
te-IN       te-IN       Telugu (India)
th          th-TH       Thai
th-TH       th-TH       Thai (Thailand)
tn-ZA       tn-ZA       Tswana (South Africa)
tr          tr-TR       Turkish
tr-TR       tr-TR       Turkish (Turkey)
tt          tt-RU       Tatar
tt-RU       tt-RU       Tatar (Russia)
uk          uk-UA       Ukrainian
uk-UA       uk-UA       Ukrainian (Ukraine)
ur          ur-PK       Urdu
ur-PK       ur-PK       Urdu (Islamic Republic of Pakistan)
uz          uz-Latn-UZ  Uzbek
uz-Cyrl-UZ  uz-Cyrl-UZ  Uzbek (Cyrillic, Uzbekistan)
uz-Latn-UZ  uz-Latn-UZ  Uzbek (Latin, Uzbekistan)
vi          vi-VN       Vietnamese
vi-VN       vi-VN       Vietnamese (Vietnam)
xh-ZA       xh-ZA       Xhosa (South Africa)
zh-CN       zh-CN       Chinese (People's Republic of China)
zh-HK       zh-HK       Chinese (Hong Kong S.A.R.)
zh-CHS      (none)      Chinese (Simplified)
zh-CHT      (none)      Chinese (Traditional)
zh-MO       zh-MO       Chinese (Macao S.A.R.)
zh-SG       zh-SG       Chinese (Singapore)
zh-TW       zh-TW       Chinese (Taiwan)
zu-ZA       zu-ZA       Zulu (South Africa)
*/
