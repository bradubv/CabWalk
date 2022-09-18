namespace MyModule
{
    public class MyPresenter
    {
        IMyView view;

        public MyPresenter(IMyView view)
        {
            this.view = view;
            view.Load += new EventHandler(view_load);
        }

        void view_load(object sender, EventArgs e)
        {
            view.Message = "Hello World form a Module";
        }
    }
}
