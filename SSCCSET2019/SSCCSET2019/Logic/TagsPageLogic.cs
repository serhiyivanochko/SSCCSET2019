using System.Collections.Generic;
using System.Linq;
using SSCCSET2019.Pages.Posts;
using SSCCSET2019.Tools;
using System.Threading;

namespace SSCCSET2019.Logic
{
    class TagsPageLogic
    {
        public Tags AddNewTagsWithSlugAndDescription(string tagName, string slug, string description)
        {
            Tags tags = new Tags(Driver.GetDriver());
            tags.ClearNameEdit();
            tags.ClickNameEdit();
            tags.InputName(tagName);
            tags.ClearSlugEdit();
            tags.ClickSlugEdit();
            tags.InputSlug(slug);
            tags.ClearDescriptionEdit();
            tags.ClickDescriptionEdit();
            tags.InputDescription(description);
            tags.ClickAddNewTagButton();
            return new Tags(Driver.GetDriver());
        }
        public Tags AddNewTagsWithSlug(string tagName, string slug)
        {
            Tags tags = new Tags(Driver.GetDriver());
            tags.ClearNameEdit();
            tags.ClickNameEdit();
            tags.InputName(tagName);
            tags.ClearSlugEdit();
            tags.ClickSlugEdit();
            tags.InputSlug(slug);
            tags.ClickAddNewTagButton();
            return new Tags(Driver.GetDriver());
        }
        public string GetNameTag(int index)
        {
            Tags tags = new Tags(Driver.GetDriver());
            return tags.listOfAddedTags[index].GetTagsName();
        }
        public string GetSlugText(int index)
        {
            Tags tags = new Tags(Driver.GetDriver());
            return tags.listOfAddedTags[index].GetSlugText();
        }
        public string GetDescriptionText(int index)
        {
            Tags tags = new Tags(Driver.GetDriver());
            return tags.listOfAddedTags[index].GetDescriptionText();
        }
        public string GetLastSlugText()
        {
            Tags tags = new Tags(Driver.GetDriver());
            return tags.listOfAddedTags.FirstOrDefault().GetSlugText();
        }
        public string GetLastDescriptionText()
        {
            Tags tags = new Tags(Driver.GetDriver());
            return tags.listOfAddedTags.FirstOrDefault().GetDescriptionText();
        }
        public string GetLastNameTag()
        {
            Tags tags = new Tags(Driver.GetDriver());
            return tags.listOfAddedTags.FirstOrDefault().GetTagsName();
        }
        public EditTags GoToEditTags(int index)
        {
            Tags tags = new Tags(Driver.GetDriver());
            tags.listOfAddedTags[index].SetActiveActionButton();
            tags.listOfAddedTags[index].EditTagsClick();
            return new EditTags(Driver.GetDriver());
        }
        public void GoQuickEdit(int index)
        {
            Tags tags = new Tags(Driver.GetDriver());
            tags.listOfAddedTags[index].SetActiveActionButton();
            tags.listOfAddedTags[index].QuickEditTagsClick();
        }
        public Tags DeleteTags(int index)
        {
            Tags tags = new Tags(Driver.GetDriver());
            tags.listOfAddedTags[index].SetActiveActionButton();
            tags.listOfAddedTags[index].DeleteTagsClick();
            tags.listOfAddedTags.RemoveAt(index);
            return new Tags(Driver.GetDriver());
        }
        public void ViewTag(int index)
        {
            Tags tags = new Tags(Driver.GetDriver());
            tags.listOfAddedTags[index].SetActiveActionButton();
            tags.listOfAddedTags[index].ViewTagsClick();
        }
        public void DeleteTagWithCheckbox(int index)
        {
            Tags tags = new Tags(Driver.GetDriver());
            tags.listOfAddedTags[index].CheckCheckbox();
            tags.SelectDeleteAction();
            tags.ClickDoActionButton();
        }
        public bool IfFoundedTags(string searchedTag)
        {
            Tags tags = new Tags(Driver.GetDriver());
            tags.ClickSearchTagsBox();
            tags.ClearSearchTagsBox();
            tags.InputSearchTagsBox(searchedTag);
            tags = tags.ClickSearchTagsButton();
            Thread.Sleep(1000);
            foreach (var list in tags.listOfAddedTags)
            {
                if (list.GetTagsName().Contains(searchedTag))
                {
                    return true;
                }
            }
            return false;
        }
        public List<AddedTags> SortTagsListByName()
        {
            Tags tags = new Tags(Driver.GetDriver());
            tags = tags.ClickDescriptionSortingIndicator();
            List<AddedTags> sortedList = tags.listOfAddedTags.OrderBy(x => x.GetTagsName()).ToList();
            return sortedList;
        }
        public List<AddedTags> SortTagsListBySlug()
        {
            Tags tags = new Tags(Driver.GetDriver());
            tags = tags.ClickDescriptionSortingIndicator();
            List<AddedTags> sortedList = tags.listOfAddedTags.OrderBy(x => x.GetSlugText()).ToList();
            return sortedList;
        }
        public List<AddedTags> SortTagsListByDescription()
        {
            Tags tags = new Tags(Driver.GetDriver());
            tags = tags.ClickDescriptionSortingIndicator();
            List<AddedTags> sortedList = tags.listOfAddedTags.OrderBy(x => x.GetDescriptionText()).ToList();
            return sortedList;
        }
        public List<AddedTags> SortTagsListByCount()
        {
            Tags tags = new Tags(Driver.GetDriver());
            tags = tags.ClickDescriptionSortingIndicator();
            List<AddedTags> sortedList = tags.listOfAddedTags.OrderBy(x => x.GetCountOfTags()).ToList();
            return sortedList;
        }
        public int NumberOfTags()
        {
            Tags tags = new Tags(Driver.GetDriver());
            return tags.listOfAddedTags.Count;
        }
        public Tags UpdateTag(int index, string newName, string newSlug)
        {
            Tags tags = new Tags(Driver.GetDriver());
            tags.listOfAddedTags[index].SetActiveActionButton();
            tags.listOfAddedTags[index].QuickEditTagsClick();
            QuickEditTag quickEditTag = new QuickEditTag(Driver.GetDriver());
            quickEditTag.ClearInputName();
            quickEditTag.ClearInputSlug();
            quickEditTag.EditInputName(newName);;
            quickEditTag.EditInputSlug(newSlug);
            quickEditTag.ClickUpdateTagButton();
            return new Tags(Driver.GetDriver());
        }
    }
}
