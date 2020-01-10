namespace StateDemo
{
    internal interface IDocumentState
    {
        void SetTitle(Document document, string value);
        bool Validate(Document document);
        void Approve(Document document);
        void Archive(Document document);
    }
}