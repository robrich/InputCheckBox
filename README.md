Input type=checkbox sample
==========================

This sample walks the user through the thought collision between 1992 `<input type="checkbox">` and 2010 ASP.NET MVC model binding.  Here's the problem and the solution:


1. In HTML, if you don't check the check-box, nothing is sent during a regular form post.  This is unexpected.

2. A careful developer can create a constructor that sets a boolean property to true, and by doing so, won't ever get unchecked check boxes.

3. ASP.NET has compensated for this by creating a parallel hidden input that they keep in sync with some JavaScript.  Now the hidden form posts a false value, and "it just works."  This is baked into `@Html.EditorFor(m => m.BooleanProperty)`, hiding the problem from developers.

4. Even better, separate data-tier constructor defaults from GUI tier view models, and don't put constructors on the view models.  This keeps the markup clean, avoids the JavaScript keeping-them-in-sync, and leverages the browser's handling of check-boxes.

Could we make this into a new `@Html.EditorFor`?  Definitely.  I leave this as an excercise to the user.
