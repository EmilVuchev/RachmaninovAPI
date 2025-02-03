using RachmaninovAPI.Models.Base;

namespace RachmaninovAPI.Extensions
{
    public static class ViewModelReverseMappingExtensions
    {
        public static TDestination To<TDestination>(
           this IMapTo<TDestination> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            return AutoMapperConfig.MapperInstance.Map<TDestination>(source);
        }
    }
}
