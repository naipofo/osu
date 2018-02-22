﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Game.Graphics;
using osu.Game.Rulesets.Edit.Layers.Selection;
using osu.Game.Rulesets.Osu.Objects;
using osu.Game.Rulesets.Osu.Objects.Drawables;
using osu.Game.Rulesets.Osu.Objects.Drawables.Pieces;
using OpenTK;

namespace osu.Game.Rulesets.Osu.Edit.Layers.Selection.Overlays
{
    public class SliderCircleOverlay : HitObjectOverlay
    {
        public SliderCircleOverlay(DrawableHitCircle sliderHead, DrawableSlider slider)
            : this(sliderHead, ((Slider)slider.HitObject).StackedPositionAt(0), slider)
        {
        }

        public SliderCircleOverlay(DrawableSliderTail sliderTail, DrawableSlider slider)
            : this(sliderTail, ((Slider)slider.HitObject).Curve.PositionAt(1) + slider.HitObject.StackOffset, slider)
        {
        }

        private SliderCircleOverlay(DrawableOsuHitObject hitObject, Vector2 position, DrawableSlider slider)
            : base(hitObject)
        {
            Origin = Anchor.Centre;

            Position = position;
            Size = slider.HeadCircle.Size;
            Scale = slider.HeadCircle.Scale;

            AddInternal(new RingPiece());
        }

        [BackgroundDependencyLoader]
        private void load(OsuColour colours)
        {
            Colour = colours.Yellow;
        }
    }
}
