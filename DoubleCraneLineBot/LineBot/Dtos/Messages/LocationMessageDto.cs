using DoubleCraneLineBot.LineBot.Enum;
namespace DoubleCraneLineBot.LineBot.Dtos
{
    public class LocationMessageDto : BaseMessageDto
    {
        public LocationMessageDto()
        {
            Type = MessageTypeEnum.Location;
        }

        public string Title { get; set; }
        public string Address { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}

