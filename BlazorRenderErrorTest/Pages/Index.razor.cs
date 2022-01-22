using BlazorRenderErrorTest.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRenderErrorTest.Pages {
  public partial class Index {
    [Inject]
    private AppDbContext Context { get; set; }
    private Person Person { get; set; }
    private List<Person> _people = new();
    private int _personId;

    protected override async Task OnInitializedAsync() {
      using (AppDbContext context = new()) {
        context.Database.Migrate();
      }
      _people = await Context.People.ToListAsync();
      await Task.Delay(10000);
      Person = _people.FirstOrDefault();
    }
  }
}
