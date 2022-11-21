using DoubleCraneLineBot.LineBot.Enum;
namespace DoubleCraneLineBot.LineBot.Dtos
{
    public class AudioMessageDto : BaseMessageDto
    {
        public AudioMessageDto()
        {
            Type = MessageTypeEnum.Audio;
        }

        public string OriginalContentUrl { get; set; }
        public int Duration { get; set; }
    }
}

