namespace StateDemo
{
    class Document
    {
        class Draft : IDocumentState
        {
            public void Approve(Document document)
            {
                document.currentState = new Approved();
            }

            public void Archive(Document document)
            {
                throw new System.Exception("Approve first");
            }

            public void SetTitle(Document document, string value)
            {
                document.title = value;
            }

            public bool Validate(Document document) => true;
        }

        class Approved : IDocumentState
        {
            public void Approve(Document document)
            {
                throw new System.Exception("Allready approved");
            }

            public void Archive(Document document)
            {
                document.currentState = new Archived();
            }

            public void SetTitle(Document document, string value)
            {
                document.title = value;
            }

            public bool Validate(Document document)
            {
                return !string.IsNullOrEmpty(document.title);
            }
        }

        class Archived : IDocumentState
        {
            public void Approve(Document document)
            {
                throw new System.Exception();
            }

            public void Archive(Document document)
            {
                throw new System.Exception();
            }

            public void SetTitle(Document document, string value)
            {
                throw new System.Exception("Can't change title when archibed");
            }

            public bool Validate(Document document)
            {
                return !string.IsNullOrEmpty(document.title);
            }
        }

        IDocumentState currentState = new Draft();

        private string title;

        public string Title
        {
            get { return title; }
            set { currentState.SetTitle(this, value); }
        }

        public bool Validate() => currentState.Validate(this);

        public void Approve() => currentState.Approve(this);
        public void Archive() => currentState.Archive(this);

    }
}
