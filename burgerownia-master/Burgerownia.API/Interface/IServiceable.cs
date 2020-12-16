namespace ObiektDwa
{
    interface IServiceable
    {
        Item[] Items { get; }
        int ItemsCount { get; }

        Item GetItemById(int itemNumber);
    }
}