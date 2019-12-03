using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace SiteServer.Abstractions
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CreateType
    {
        [Display(Name = "��Ŀҳ")]
        Channel,
        [Display(Name = "����ҳ")]
        Content,
        [Display(Name = "�ļ�ҳ")]
        File,
        [Display(Name = "ר��ҳ")]
        Special,
        [Display(Name = "��Ŀ����������ҳ")]
        AllContent
    }
}
