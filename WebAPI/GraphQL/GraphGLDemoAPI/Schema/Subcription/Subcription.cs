using GraphGLDemoAPI.Schema.Models;
using GraphGLDemoAPI.Schema.Queries;
using HotChocolate.Execution;
using HotChocolate.Subscriptions;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace GraphGLDemoAPI.Schema.Subcription
{
    public class Subcription
    {
        [Subscribe]
        public CourseResults CourseCreated([EventMessage] CourseResults course) => course;
        
    }
}
