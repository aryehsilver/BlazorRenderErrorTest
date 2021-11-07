using BlazorRenderErrorTest.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorRenderErrorTest.Pages {
  public partial class Index {
    [Inject]
    private AppDbContext Context { get; set; }
    private Person Person;
    private List<Person> People = new();
    private int PersonId;
    protected override async Task OnInitializedAsync() {
      using (AppDbContext context = new()) {
        context.Database.Migrate();
      }
      People = await Context.People.ToListAsync();
      await Task.Delay(10000);
      Person = new() {
        Id = 1,
        Name = "New person",
        Tel = 05654534674
      };
    }
  }
}
