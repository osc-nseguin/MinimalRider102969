using AutoFixture;
using AutoFixture.AutoFakeItEasy;
using AutoFixture.Xunit2;

namespace MinimalRider102969;

public class AutoFakeDataAttribute : AutoDataAttribute
{
    public AutoFakeDataAttribute()
        : base(() =>
        {
            var fixture = new Fixture();
            fixture.Customize(new AutoFakeItEasyCustomization());
            return fixture;
        }) { }
}