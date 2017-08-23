namespace TrackerWatchServer.View
{
    internal class TextRange
    {
        private object contentStart;
        private object contentEnd;

        public TextRange(object contentStart, object contentEnd)
        {
            this.contentStart = contentStart;
            this.contentEnd = contentEnd;
        }
    }
}