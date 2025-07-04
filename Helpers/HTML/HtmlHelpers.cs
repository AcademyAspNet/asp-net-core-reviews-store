using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text;
using System.Text.Encodings.Web;

namespace OnlineStoreReviews.Helpers.HTML
{
    public static class HtmlHelpers
    {
        public static HtmlString CreateDateTime(this IHtmlHelper helper, DateTime dateTime)
        {
            string html = $"<p>{dateTime.ToString()}</p>";
            return new HtmlString(html);
        }

        public static HtmlString CreateOrderedList<T>(this IHtmlHelper helper, List<T> list)
        {
            TagBuilder ol = new TagBuilder("ol");
            ol.Attributes.Add("class", "list-group list-group-numbered");

            foreach (T item in list)
            {
                if (item is null)
                    continue;

                TagBuilder li = new TagBuilder("li");
                li.Attributes.Add("class", "list-group-item");

                li.InnerHtml.Append(item.ToString() ?? string.Empty);
                ol.InnerHtml.AppendHtml(li);
            }

            string? html = null;

            using (StringWriter writer = new StringWriter())
            {
                ol.WriteTo(writer, HtmlEncoder.Default);
                html = writer.ToString();
            }

            return new HtmlString(html);
        }
    }
}
