namespace SOM.Core.IEntity
{
    internal interface IBaseEntity<TId>
    {
        public TId Id { get; set; }
    }
}
