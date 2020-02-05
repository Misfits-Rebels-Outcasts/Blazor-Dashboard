using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Components.Layouts;
using Blazor_Dashboard.Shared;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Blazor;

namespace BlazorDashboard.Pages
{
    [Route("/classrender")]
    [Layout(typeof(MainLayout))]
    public class ClassOnlyComponent : ComponentBase
    {
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            Action<UIMouseEventArgs> act1 = new Action<UIMouseEventArgs>((s) =>
            {
                onclick(s);
            });
            var seq = 0;
            builder.OpenElement(seq, "h3");
            builder.AddContent(++seq, title);
            builder.CloseElement();
            builder.OpenElement(++seq, "button");
            builder.AddAttribute(++seq, "onclick", onclick);
            builder.AddContent(++seq, "Click");
            builder.CloseElement();
            base.BuildRenderTree(builder);
        }        
             
        protected string title = "BuildRenderTree Action";
        public void onclick(UIMouseEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Hello");
            title = "Hello OnClick";
            //StateHasChanged();
            //ActionClicked?.Invoke(e);

        }

        public Action<UIMouseEventArgs> ActionClicked;
        public async void hello()
        {
            System.Diagnostics.Debug.WriteLine("Hello");
        }
        
    }
}
