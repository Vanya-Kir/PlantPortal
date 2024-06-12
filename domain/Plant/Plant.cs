namespace Plant
{
    /// <summary>
    /// Справочник цветов
    /// </summary>
    public class Plant
    {
        public long Id { get; set; }

        public required string Name { get; set; }

        public string? LatinName { get; set; }

        public string? Description { get; set; }

        public DateOnly DateUpdate { get; set; }

        /// <summary>
        /// Вид растения
        /// </summary>
        public string? Species { get; set; }

        /// <summary>
        /// Погодные условия для выращивания
        /// </summary>
        public List<Weather>? Weather { get; set; }

        public List<string>? Images { get; set; }

        List<Disease>? Diseases { get; set; }
    }
}
