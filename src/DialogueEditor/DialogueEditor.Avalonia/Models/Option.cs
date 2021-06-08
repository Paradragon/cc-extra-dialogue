﻿
namespace DialogueEditor.Models
{
    public class Option
    {
        // Todo: Refactor options to stoge generic <T> data instead of objet
        public object OptionData { get; }

        public string Title { get; }

        public object Image { get; }

        public Option(object optionData, string title, object image)
        {
            OptionData = optionData;
            Title = title;
            Image = image;
        }
    }
}
