 
using System;
using System.Linq.Expressions;
using Machine.Specifications;
using Machine.Specifications.DevelopWithPassion.Rhino;

namespace nothinbutdotnetstore.specs.concepts
{
    public class ExpressionTreesSpecs
    {
        public abstract class concern : Observes
        {

        }

        [Subject(typeof(Expression<>))]
        public class when_playing_around_with_expressions : concern
        {
            It should_be_able_to_create_an_expression_tree_manually = () =>
            {
                var number2 = Expression.Constant(2);
                var number_3 = Expression.Constant(3);
                var binary_expression = Expression.Add(number2,number_3);

                var expression = Expression.Lambda<Func<int>>(binary_expression);
            };

                
        }
    }
}
