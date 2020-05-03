using StarkovInteractiveCV.VisualElements.Pages.DevSkillsPopup.Enums;

namespace StarkovInteractiveCV.VisualElements.Pages.DevSkillsPopup.UIModels
{
    public class SkillUIModel
    {
        public KnowledgeType SkillType { get; }
        public string Name { get; }

        public SkillUIModel(KnowledgeType skillType, string name)
        {
            SkillType = skillType;
            Name = name;
        }
    }
}
