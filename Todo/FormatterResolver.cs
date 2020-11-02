using System;
using System.Collections.Generic;
using System.Linq;

namespace Todo
{
    public class FormatterResolver
    {
        private readonly List<IFormatter> _formatters;

        public FormatterResolver(List<IFormatter> formatters)
        {
            _formatters = formatters;
        }
        
        public IFormatter Resolve(ITodo todo)
        {
            return _formatters.FirstOrDefault(formatter => formatter.Support(todo));
        }
    }
}