using System.Collections.Generic;

namespace SettingsMaster
{
    class Cursor
    {
        private Dictionary<CursorType, string> cursorPaths;

        public Cursor(Dictionary<CursorType, string> cursorPaths)
        {
            this.cursorPaths = cursorPaths;
        }

        public string GetCursorPath(CursorType type)
        {
            if (!cursorPaths.ContainsKey(type)) return null;
            return cursorPaths[type];
        }

    }
}
