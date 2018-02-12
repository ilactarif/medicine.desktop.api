namespace Medicine.Desktop.Api {

    public interface IJsonSerializer {
        string ToJson(object o);
    }

}