using System;
using System.Windows.Forms;

namespace Euler.Problems
{
    public abstract class ProblemBase
    {
        public string Title { get; }
        public string Description { get; }
        public long Answer { get; }

        protected ProblemBase(string title, string description, long answer)
        {
            Title = title;
            Description = description;
            Answer = answer;
        }

        public abstract long Solve();

        public void Display()
        {
            var startTime = DateTime.Now;
            var calculatedAnswer = Solve();
            var endTime = DateTime.Now;

            var elapseTime = endTime - startTime;

            var text = string.Join(Environment.NewLine + Environment.NewLine,
                Description,
                "Answer: " + calculatedAnswer,
                "Elapsed Time: " + elapseTime.TotalMilliseconds + "ms");

            var icon = Answer == calculatedAnswer
                ? MessageBoxIcon.Information
                : MessageBoxIcon.Error;

            MessageBox.Show(
                text: text,
                caption: Title,
                buttons: MessageBoxButtons.OK,
                icon: icon);
        }
    }

}