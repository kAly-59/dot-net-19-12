using Microsoft.AspNetCore.Components;

namespace DemoBlazor.Pages
{
    public partial class Counter
    //public class CounterBase : ComponentBase
    {
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount += 10;
        }

        private void DecrementCount()
        {
            currentCount -= 10;
        }
    }
}
